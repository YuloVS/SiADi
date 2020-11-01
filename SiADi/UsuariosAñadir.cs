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
    public partial class UsuariosAñadir : Form
    {
        private Verificaciones verificaciones = new Verificaciones();
        private bool errorDni = true;
        private bool errorCuil = true;
        private bool errorNombre = true;
        private bool errorApellido = true;
        private bool errorFecha = false;
        private bool errorTelefono = true;
        private bool errorDireccion = true;
        private bool errorImagen = false;
        private Persona usuario;
        private bool admin;

        public UsuariosAñadir(Persona persona, bool esAdmin)
        {
            InitializeComponent();
            this.usuario = persona;
            this.admin = esAdmin;
            cargarComboBoxArea();
            labelEdad2.Hide();
            textBoxEdad2.Hide();
            buttonAgregarFoto.Hide();
            labelTelefono2.Hide();
            textBoxTelefono2.Hide();
            pictureBoxUsuario2.Hide();
            labelFechaNacimiento2.Hide();
            labelNombre2.Hide();
            labelApellido2.Hide();
            labelCUIL2.Hide();
            labelDNI2.Hide();
            labelDireccion2.Hide();
            labelArea2.Hide();
            labelCargo2.Hide();
            buttonCancelar.Hide();
            buttonEditar.Hide();
            buttonEliminar.Hide();
            //cargarComboBoxCargo(); TODO: Guardar todo en Mayus
        }
        
        public UsuariosAñadir(Persona persona, bool esAdmin, Persona usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.admin = esAdmin;
            labelUsuariosAñadir.Text = "Modificar Usuario";
            this.CenterToScreen();
            cargarComboBoxArea();
            modoEdicion();
            labelEdad.Hide();
            textBoxEdad.Hide();
            btnAgregarFoto.Hide();
            labelTelefono.Hide();
            textBoxTelefono.Hide();
            pictureBoxUsuario.Hide();
            labelFechaNacimiento.Hide();
            labelNombre.Hide();
            labelApellido.Hide();
            labelCUIL.Hide();
            labelDNI.Hide();
            labelDireccion.Hide();
            labelArea.Hide();
            labelCargo.Hide();
            btnCrear.Hide();
            btnLimpiar.Hide();
            errorDni = false;
            errorCuil = false;
            errorNombre = false;
            errorApellido = false;
            errorFecha = false;
            errorTelefono = false;
            errorDireccion = false;
            errorImagen = false;
        }

        private void modoEdicion()
        {
            this.textBoxDNI.Text = usuario.Dni.ToString();
            this.textBoxCUIL.Text = usuario.Cuil.ToString();
            this.textBoxNombre.Text = usuario.Nombre;
            this.textBoxApellido.Text = usuario.Apellido;
            this.dateTimePickerFechaNacimiento.Value = usuario.Fecha_nacimiento;
            this.textBoxEdad2.Text = usuario.Edad.ToString();
            this.textBoxTelefono2.Text = usuario.Telefono.ToString();
            this.textBoxDireccion.Text = usuario.Direccion;
            this.comboBoxArea.SelectedValue = usuario.Cargo.Area.Id;
            this.comboBoxCargo.SelectedValue = usuario.Cargo.Id;
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
            textBoxEdad2.Text = (ahora.Year - dateTimePickerFechaNacimiento.Value.Year).ToString();
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
            return errorApellido || errorCuil || errorDireccion || errorDni || errorFecha || errorImagen || errorNombre || errorTelefono;
        }

        private void cargarComboBoxArea()
        {
            using (var db = new SiADiDB())
            {
                if (admin)
                {
                    comboBoxArea.DataSource = db.Areas.Where(a => a.baja == false).ToList();
                }
                else 
                {
                    Cargo cargo = this.usuario.Cargo;
                    comboBoxArea.DataSource = db.Areas.Where(a => a.baja == false && a.Id == cargo.AreaId).ToList();
                }
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
                    comboBoxCargo.DataSource = db.Areas.Find(comboBoxArea.SelectedValue)?.Cargos.Where(c => c.baja == false).ToList();
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
                    Persona persona = new Persona { Dni = Int32.Parse(textBoxDNI.Text), Cuil = Int64.Parse(textBoxCUIL.Text), Nombre = textBoxNombre.Text, Apellido = textBoxApellido.Text, Fecha_nacimiento = dateTimePickerFechaNacimiento.Value, Telefono = Int64.Parse(textBoxTelefono.Text), Direccion = textBoxDireccion.Text, Cargo = db.Cargos.Find(comboBoxCargo.SelectedValue), Contraseña = crearContraseña(), Edad = Int32.Parse(textBoxEdad.Text), Encargado = checkBoxEncargado.Checked };
                    db.Personas.Add(persona);
                    db.SaveChanges();
                }
                MessageBox.Show("Usuario añadido. La contraseña es: "+crearContraseña(), "SiADi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxDNI.Clear();
                textBoxCUIL.Clear();
                textBoxNombre.Clear();
                textBoxApellido.Clear();
                textBoxTelefono.Clear();
                textBoxDireccion.Clear();
                errorProvider1.Clear();
                errorDni = true;
                errorCuil = true;
                errorNombre = true;
                errorApellido = true;
                errorFecha = true;
                errorTelefono = true;
                errorDireccion = true;
                errorImagen = true;
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
        private string crearContraseña()
        {
            return textBoxNombre.Text.Substring(0, 2) + textBoxApellido.Text.Substring(0, 2) + textBoxCUIL.Text.Substring(0, 4);
        }

        private void buttonAgregarFoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                string imagen = openFileDialog2.FileName;
                if (Image.FromFile(imagen).Width == Image.FromFile(imagen).Height)
                {
                    pictureBoxUsuario2.Image = Image.FromFile(imagen);
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

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            using (var db = new SiADiDB())
            {
                var query = from u in db.Personas
                            where u.Id == usuario.Id
                            select u;
                foreach (var tPersona in query)
                {
                    tPersona.baja = true;
                }
                db.SaveChanges();
                MessageBox.Show("El usuario ha sido dado de baja.", "SiADi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxTelefono2_Validated(object sender, EventArgs e)
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

        private void textBoxTelefono2_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificaciones.soloNumeros(e);
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (!hayErrores())
            {
                using (var db = new SiADiDB())
                {
                    Persona personaupdate = db.Personas.Find(usuario.Id);
                    personaupdate.Dni = Convert.ToInt32(textBoxDNI.Text);
                    personaupdate.Cuil = Convert.ToInt64(textBoxCUIL.Text);
                    personaupdate.Nombre = textBoxNombre.Text;
                    personaupdate.Apellido = textBoxApellido.Text;
                    personaupdate.Fecha_nacimiento = dateTimePickerFechaNacimiento.Value;
                    personaupdate.Edad = Convert.ToInt32(textBoxEdad2.Text);
                    personaupdate.Telefono = Convert.ToInt64(textBoxTelefono2.Text);
                    personaupdate.Cargo.Area = db.Areas.Find(comboBoxArea.SelectedValue);
                    personaupdate.Encargado = checkBoxEncargado.Checked;
                    personaupdate.Cargo = db.Cargos.Find(comboBoxCargo.SelectedValue);
                    db.SaveChanges();
                    MessageBox.Show("El usuario ha sido modificado.", "SiADi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
                errorProvider1.Clear();
                errorDni = true;
                errorCuil = true;
                errorNombre = true;
                errorApellido = true;
                errorFecha = true;
                errorTelefono = true;
                errorDireccion = true;
                errorImagen = true;
            }
            else
            {
                MessageBox.Show("Error, verifique los campos.", "SiADi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
