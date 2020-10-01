using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PlayerUI
{
    public partial class UsuariosAñadir : Form
    {
        private Verificaciones verificaciones = new Verificaciones();
        public UsuariosAñadir()
        {
            InitializeComponent();
            
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDNI_TextChanged(object sender, EventArgs e)
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
            }
            else
            {
                errorProvider1.Clear();
            }
            
        }

        private void textBoxCUIL_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificaciones.soloNumeros(e);
        }

        private void textBoxCUIL_Validating(object sender, CancelEventArgs e)
        { 
            if (textBoxCUIL.TextLength != textBoxDNI.TextLength + 3 || !textBoxCUIL.Text.Contains(textBoxDNI.Text))
            {
                errorProvider1.SetError(textBoxCUIL, "CUIL invalido.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificaciones.soloLetras(e);
        }

        private void textBoxNombre_Validating(object sender, CancelEventArgs e)
        {
            if(textBoxNombre.TextLength < 2)
            {
                errorProvider1.SetError(textBoxNombre, "Nombre invalido.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificaciones.soloLetras(e);
        }

        private void textBoxApellido_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxApellido.TextLength < 2)
            {
                errorProvider1.SetError(textBoxApellido, "Apellido invalido.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void dateTimePickerFechaNacimiento_Leave(object sender, EventArgs e)
        {
            DateTime ahora = DateTime.Now;
            textBoxEdad.Text = (ahora.Year - dateTimePickerFechaNacimiento.Value.Year).ToString();
        }

        private void textBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificaciones.soloNumeros(e);
        }

        private void textBoxTelefono_Validated(object sender, EventArgs e)
        {
            if (textBoxTelefono.TextLength < 10)
            {
                errorProvider1.SetError(textBoxTelefono, "Número telefonico invalido.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBoxDireccion_Validated(object sender, EventArgs e)
        {
            if (textBoxDireccion.TextLength < 6)
            {
                errorProvider1.SetError(textBoxDireccion, "Dirección invalida.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
