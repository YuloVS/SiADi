using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiADi
{
    public partial class IngresoVista : Form
    {
        private Verificaciones verificaciones = new Verificaciones();
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

        private void button9_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();

            this.Hide();

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
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBoxContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificaciones.soloLetras(e);
        }

        private void textBoxContraseña_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxContraseña.TextLength != 2)
            {
                errorProvider1.SetError(textBoxContraseña, "Contraseña invalida.");
                verificaciones.bordeError(textBoxContraseña, this);
            }
            else
            {
                errorProvider1.Clear();
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
    }
}
