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
    public partial class BaseDatos : Form
    {
        public BaseDatos()
        {
            InitializeComponent();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            AdminDB adb = new AdminDB();
            adb.backup();
            MessageBox.Show("Backup generado, si desea restaurar la base de datos comuniquese con el encargado de sistemas.", "SiADi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            AdminDB adb = new AdminDB();
            adb.restore();
        }
    }
}
