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
    public partial class AreasAñadir : Form
    {
        private Verificaciones verificaciones = new Verificaciones();
        private int error = 1;
        public AreasAñadir()
        {
            InitializeComponent();
        }

        private void TextboxNombreAreasAñadir_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificaciones.soloLetras(e);
        }

        private void TextboxDescipcionAreasAñadir_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificaciones.soloLetras(e);
        }

        private void TextboxNombreAreasAñadir_Validated(object sender, EventArgs e)
        {
            if (TextboxNombreAreasAñadir.TextLength < 3)
            {
                errorProvider1.SetError(TextboxNombreAreasAñadir, "Ingrese un nombre válido.");
                error = 1;
                verificaciones.bordeError(TextboxNombreAreasAñadir, this);
            }
            else
            {
                errorProvider1.Clear();
                error = 0;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.TextboxNombreAreasAñadir.Clear();
            this.TextboxDescipcionAreasAñadir.Clear();
            errorProvider1.Clear();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if(error == 0)
            {
                using (var db = new SiADiDB())
                {
                    db.Areas.Add(new Area { Nombre = TextboxNombreAreasAñadir.Text, Descripcion = TextboxDescipcionAreasAñadir.Text });
                    db.SaveChanges();
                }
                MessageBox.Show("Area añadida.", "SiADi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.TextboxNombreAreasAñadir.Clear();
                this.TextboxDescipcionAreasAñadir.Clear();
                errorProvider1.Clear();
                error = 1;
            }
            else
            {
                MessageBox.Show("Error, verifique el campo 'Nombre'.", "SiADi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
