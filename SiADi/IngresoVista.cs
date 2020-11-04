using AForge.Video.DirectShow;
using SiADi.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace SiADi
{
    public partial class IngresoVista : Form
    {
        private Verificaciones verificaciones = new Verificaciones();
        bool errorDni = true;
        bool errorContraseña = true;
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        public IngresoVista()
        {
            InitializeComponent();
            textBoxContraseña.UseSystemPasswordChar = true;

        }

        private void textBoxDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificaciones.soloNumeros(e);
        }

        private void textBoxDNI_Validating(object sender, CancelEventArgs e)
        {
            if(textBoxDNI.TextLength < 7 || Int32.Parse(textBoxDNI.Text) <= 8000000)
            {
                errorProvider1.SetError(textBoxDNI, "Ingrese un DNI válido.");
                verificaciones.bordeError(textBoxDNI, this);
                errorDni = true;
            }
            else
            {
                errorProvider1.Clear();
                errorDni = false;
            }
        }

        private void textBoxContraseña_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxContraseña.TextLength != 8)
            {
                errorProvider1.SetError(textBoxContraseña, "Contraseña invalida.");
                verificaciones.bordeError(textBoxContraseña, this);
                errorContraseña = true;
            }
            else
            {
                errorProvider1.Clear();
                errorContraseña = false;
            }
        }

        private void checkBoxContraseña_CheckedChanged(object sender, EventArgs e)
        {
            string text = textBoxContraseña.Text;
            if (checkBoxContraseña.Checked)
            {
                textBoxContraseña.UseSystemPasswordChar = false;
                textBoxContraseña.Text = text;

            }
            else
            {
                textBoxContraseña.UseSystemPasswordChar = true;
                textBoxContraseña.Text = text;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!errorDni && !errorContraseña)
            {
                using (var db = new SiADiDB())
                {
                    int dni = Int32.Parse(textBoxDNI.Text);
                    if(db.Personas.SingleOrDefault<Persona>(persona => persona.Dni == dni)?.Contraseña == textBoxContraseña.Text)
                    {
                        bool admin;
                        Persona usuario = db.Personas.Include("Cargo").SingleOrDefault<Persona>(persona => persona.Dni == dni);
                        if(usuario.Id == 1)
                        {
                            admin = true;
                        }
                        else
                        {
                            admin = false;
                        }
                        if(usuario.Encargado)
                        {
                            Principal principal = new Principal(usuario, admin);
                            principal.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Acceso no autorizado: comuniquese con el/los encargado/s de su área para obtenerlo.", "SiADi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: datos invalidos.", "SiADi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Error: verifique los campos.", "SiADi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IngresoVista_Load(object sender, EventArgs e)
        {
            try
            {
                filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo Device in filterInfoCollection)
                    comboBoxCamara.Items.Add(Device.Name);
                comboBoxCamara.SelectedIndex = 0;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Error: no posee camaras, no podrá usar el sistema para escanear asistencias.", "SiADi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnEnviar.Enabled = false;
                labelQR.Text = "No posee camara";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBoxCamara.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBoxCamara.Image);
                if(result != null)
                {
                    timer1.Stop();
                    if (videoCaptureDevice.IsRunning)
                        videoCaptureDevice.Stop();
                    //CODIGO DE ASISTENCIA
                    using (var db = new SiADiDB())
                    {
                        long cuil = long.Parse(result.Text);
                        Persona persona = db.Personas.FirstOrDefault(p => p.Cuil == cuil);
                        Asistencia asistencia = new Asistencia();
                        asistencia.Fecha = DateTime.Today;
                        asistencia.Hora = DateTime.Now;
                        var ultima =
                            (from a in db.Asistencias orderby a.Id descending where a.PersonaId == persona.Id select a.Tipo)
                            .FirstOrDefault();
                        if (ultima != null)
                        {
                            asistencia.Tipo = !ultima;
                        }
                        else
                        {
                            asistencia.Tipo = true;
                        }
                        persona?.Asistencias.Add(asistencia);
                        db.SaveChanges();
                        if (ultima)
                        {
                            string msj = "Hora de salida registrada.\nAdios " + persona.Apellido + " " +
                                         persona.Nombre + "!";
                            MessageBox.Show(msj, "SiADi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            string msj = "Hora de ingreso registrada.\nHola " + persona.Apellido + " " +
                                         persona.Nombre + "!";
                            MessageBox.Show(msj, "SiADi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[comboBoxCamara.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
            timer1.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            pictureBoxCamara.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void IngresoVista_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (videoCaptureDevice != null)
                {
                    if (videoCaptureDevice.IsRunning)
                        videoCaptureDevice.Stop();
                }
            }
            catch (System.NullReferenceException)
            {
                Console.WriteLine("Sin cámara");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
