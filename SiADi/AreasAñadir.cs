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
            }
            else
            {
                errorProvider1.Clear();
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

        }
    }
}
