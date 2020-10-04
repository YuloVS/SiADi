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
        public CargosAñadir()
        {
            InitializeComponent();
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
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void dateTimePickerHasta_Validating(object sender, CancelEventArgs e)
        {
            int horas = horarioSalida.Value.Hour - horarioEntrada.Value.Hour;
            if (horas < 4)
            {
                errorProvider1.SetError(horarioEntrada, "La cantidad minima de horas es cuatro.");
                errorProvider1.SetError(horarioSalida, "La cantidad minima de horas es cuatro.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void dateTimePickerDesde_Validating(object sender, CancelEventArgs e)
        {
            int horas = horarioSalida.Value.Hour - horarioEntrada.Value.Hour;
            if (horas < 4)
            {
                errorProvider1.SetError(horarioEntrada, "La cantidad minima de horas es cuatro.");
                errorProvider1.SetError(horarioSalida, "La cantidad minima de horas es cuatro.");
            }
            else
            {
                errorProvider1.Clear();
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
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
            catch (SystemException) 
            {
                errorProvider1.SetError(textBoxSalario, "El salario minimo es $10.000.");
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.textBoxNombre.Clear();
            this.textBoxSalario.Clear();
            errorProvider1.Clear();
        }
    }
}
