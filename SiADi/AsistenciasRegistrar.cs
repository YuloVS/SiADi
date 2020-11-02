using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using SiADi.Modelo;
using ZXing;

namespace SiADi
{
    public partial class AsistenciasRegistrar : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        public AsistenciasRegistrar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AsistenciasRegistrar_Load(object sender, EventArgs e)
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
                            .First();
                        asistencia.Tipo = !ultima;
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


        private void AsistenciasRegistrar_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
