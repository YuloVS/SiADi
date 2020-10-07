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

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void textBoxContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            //verificaciones.soloLetras(e);
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
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in filterInfoCollection)
                comboBoxCamara.Items.Add(Device.Name);
            comboBoxCamara.SelectedIndex = 0;
            //videoCaptureDevice = new VideoCaptureDevice();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBoxCamara.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBoxCamara.Image);
                if(result != null)
                {
                    textBoxDNI.Text = result.ToString();
                    timer1.Stop();
                    if (videoCaptureDevice.IsRunning)
                        videoCaptureDevice.Stop();
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
            /*try
            {
                if (videoCaptureDevice.IsRunning)
                    videoCaptureDevice.Stop();
            }
            catch(System.NullReferenceException)
            {
                Console.WriteLine("Camara apagada");
            }*/
        }

        private void pictureBoxCamara_Click(object sender, EventArgs e)
        {

        }
    }
}
