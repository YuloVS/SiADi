﻿using SiADi.Modelo;
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
    public partial class UsuariosAñadir : Form
    {
        private Verificaciones verificaciones = new Verificaciones();
        private bool errorDni = true;
        private bool errorCuil = true;
        private bool errorNombre = true;
        private bool errorApellido = true;
        private bool errorFecha = true;
        private bool errorTelefono = true;
        private bool errorDireccion = true;
        private bool errorImagen = true;

        public UsuariosAñadir()
        {
            InitializeComponent();
            cargarComboBoxArea();
            //cargarComboBoxCargo();

        }

        private void textBoxDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificaciones.soloNumeros(e);
        }

        private void textBoxDNI_Validating(object sender, CancelEventArgs e)
        {
            if(textBoxDNI.TextLength < 7 || Int32.Parse(textBoxDNI.Text) <= 8000000)
            {
                errorProvider1.SetError(textBoxDNI, "DNI invalido.");
                verificaciones.bordeError(textBoxDNI, this);
                errorDni = true;
            }
            else
            {
                errorProvider1.Clear();
                errorDni = false;
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
                verificaciones.bordeError(textBoxCUIL, this);
                errorCuil = true;
            }
            else
            {
                errorProvider1.Clear();
                errorCuil = false;
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
                verificaciones.bordeError(textBoxNombre, this);
                errorNombre = true;
            }
            else
            {
                errorProvider1.Clear();
                errorNombre = false;
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
                verificaciones.bordeError(textBoxApellido, this);
                errorApellido = true;
            }
            else
            {
                errorProvider1.Clear();
                errorApellido = false;
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
                verificaciones.bordeError(textBoxTelefono, this);
                errorTelefono = true;
            }
            else
            {
                errorProvider1.Clear();
                errorTelefono = false;
            }
        }

        private void textBoxDireccion_Validated(object sender, EventArgs e)
        {
            if (textBoxDireccion.TextLength < 6)
            {
                errorProvider1.SetError(textBoxDireccion, "Dirección invalida.");
                verificaciones.bordeError(textBoxDireccion, this);
                errorDireccion = true;
            }
            else
            {
                errorProvider1.Clear();
                errorDireccion = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.textBoxNombre.Clear();
            this.textBoxDNI.Clear();
            this.textBoxCUIL.Clear();
            this.textBoxApellido.Clear();
            this.textBoxEdad.Clear();
            this.textBoxTelefono.Clear();
            this.textBoxDireccion.Clear();
            errorProvider1.Clear();
        }

        private void btnAgregarFoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                string imagen = openFileDialog2.FileName;
                if (Image.FromFile(imagen).Width == Image.FromFile(imagen).Height)
                {
                    pictureBoxUsuario.Image = Image.FromFile(imagen);
                    errorImagen = false;
                }
                else
                {
                    MessageBox.Show("La imagen debe ser cuadrada", "SiADi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    errorImagen = true;
                }
            }
            else
            {
                errorImagen = true;
            }
        }

        private bool hayErrores()
        {
            return !errorApellido && !errorCuil && !errorDireccion && !errorDni && !errorFecha && !errorImagen && !errorNombre && !errorTelefono;
        }

        private void cargarComboBoxArea()
        {
            using (var db = new SiADiDB())
            {
                comboBoxArea.DataSource = db.Areas.ToList();
                comboBoxArea.DisplayMember = "Nombre";
                comboBoxArea.ValueMember = "Id";
                comboBoxArea.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void cargarComboBoxCargo()
        {
            try
            {
                using (var db = new SiADiDB())
                            {
                                comboBoxCargo.DataSource = db.Areas.Find(comboBoxArea.SelectedValue).Cargos.ToList();
                                comboBoxCargo.DisplayMember = "Nombre";
                                comboBoxCargo.ValueMember = "Id";
                                comboBoxCargo.DropDownStyle = ComboBoxStyle.DropDownList;
                            }
            }
            catch(System.ArgumentOutOfRangeException)
            {
                Console.WriteLine("Error");
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (!hayErrores())
            {
                using (var db = new SiADiDB())
                {
                    Persona persona = new Persona { Dni = Int32.Parse(textBoxDNI.Text), Cuil = Int64.Parse(textBoxCUIL.Text), Nombre = textBoxNombre.Text, Apellido = textBoxApellido.Text, Fecha_nacimiento = dateTimePickerFechaNacimiento.Value, Telefono = Int64.Parse(textBoxTelefono.Text), Direccion = textBoxDireccion.Text, Cargo = db.Cargos.Find(comboBoxCargo.SelectedValue) };
                    db.Personas.Add(persona);
                    db.SaveChanges();
                }
                MessageBox.Show("Usuario añadido.", "SiADi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxDNI.Clear();
                textBoxCUIL.Clear();
                textBoxNombre.Clear();
                textBoxApellido.Clear();
                textBoxTelefono.Clear();
                textBoxDireccion.Clear();
                errorProvider1.Clear(); //TODO POPULAR COMBOBOX
            }
            else
            {
                MessageBox.Show("Error, verifique los campos.", "SiADi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxArea_SelectedValueChanged(object sender, EventArgs e)
        {
            cargarComboBoxCargo();
        }
    }
}
