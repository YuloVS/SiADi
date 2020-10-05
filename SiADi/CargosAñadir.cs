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
    public partial class CargosAñadir : Form
    {
        private Verificaciones verificaciones = new Verificaciones();
        private bool errorNombre=true;
        private bool errorHorario=true;
        private bool errorSalario=true;
        public CargosAñadir()
        {
            InitializeComponent();
            cargarComboBox();
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificaciones.soloLetras(e);
        }

        private void textBoxNombre_Validated(object sender, EventArgs e)
        {
            if(textBoxNombre.TextLength < 3)
            {
                errorProvider1.SetError(textBoxNombre, "Ingrese un nombre válido.");
                errorNombre = true;
                verificaciones.bordeError(textBoxNombre, this);
            }
            else
            {
                errorProvider1.Clear();
                errorNombre = false;
            }
        }

        private void dateTimePickerHasta_Validating(object sender, CancelEventArgs e)
        {
            int horas = horarioSalida.Value.Hour - horarioEntrada.Value.Hour;
            if (horas < 4)
            {
                errorProvider1.SetError(horarioEntrada, "La cantidad minima de horas es cuatro.");
                errorProvider1.SetError(horarioSalida, "La cantidad minima de horas es cuatro.");
                errorHorario = true;
            }
            else
            {
                errorProvider1.Clear();
                errorHorario = false;
            }
        }

        private void dateTimePickerDesde_Validating(object sender, CancelEventArgs e)
        {
            int horas = horarioSalida.Value.Hour - horarioEntrada.Value.Hour;
            if (horas < 4)
            {
                errorProvider1.SetError(horarioEntrada, "La cantidad minima de horas es cuatro.");
                errorProvider1.SetError(horarioSalida, "La cantidad minima de horas es cuatro.");
                errorHorario = true;
            }
            else
            {
                errorProvider1.Clear();
                errorHorario = false;
            }
        }

        private void dateTimePickerDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            horarioEntrada.Value = horarioEntrada.Value.AddHours(horarioEntrada.Value.Hour + 4);
            //TODO: Que la diferencia entre desde y hasta automaticamente sea minimamente 4.
        }

        private void textBoxSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificaciones.soloNumeros(e);
        }

        private void textBoxSalario_Validated(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(textBoxSalario.Text) < 10000)
                {
                    errorProvider1.SetError(textBoxSalario, "El salario minimo es $10.000.");
                    errorSalario = true;
                    verificaciones.bordeError(textBoxSalario, this);
                }
                else
                {
                    errorProvider1.Clear();
                    errorSalario = false;
                }
            }
            catch (SystemException) 
            {
                errorProvider1.SetError(textBoxSalario, "El salario minimo es $10.000.");
                errorSalario = true;
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.textBoxNombre.Clear();
            this.textBoxSalario.Clear();
            errorProvider1.Clear();
        }
        private void cargarComboBox()
        {
            using (var db = new SiADiDB())
            {
                comboBoxArea.DataSource = db.Areas.ToList();
                comboBoxArea.DisplayMember = "Nombre";
                comboBoxArea.ValueMember = "Id";
                comboBoxArea.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (!errorHorario && !errorNombre && !errorSalario)
            {
                using (var db = new SiADiDB())
                {
                    db.Areas.Find(comboBoxArea.SelectedValue)?.Cargos.Add(new Cargo { Nombre = textBoxNombre.Text, Salario = float.Parse(textBoxSalario.Text), Horario_entrada = horarioEntrada.Value, Horario_salida = horarioSalida.Value });
                    db.SaveChanges();
                }
                MessageBox.Show("Cargo añadido.", "SiADi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBoxNombre.Clear();
                this.textBoxSalario.Clear();
                errorProvider1.Clear();
                errorNombre = true;
                errorHorario = true;
                errorSalario = true;
            }
            else
            {
                MessageBox.Show("Error, verifique los campos.", "SiADi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
