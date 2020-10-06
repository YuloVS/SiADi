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

namespace SiADi
{
    public partial class IngresoVista : Form
    {
        private Verificaciones verificaciones = new Verificaciones();
        bool errorDni = true;
        bool errorContraseña = true;
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
                    if (db.Personas.SingleOrDefault<Persona>(persona => persona.Dni == dni)?.Contraseña == textBoxContraseña.Text)
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
                        Principal principal = new Principal(usuario, admin);
                        principal.Show();
                        this.Hide();
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
    }
}
