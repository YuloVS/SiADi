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
using System.Windows.Forms.VisualStyles;

namespace SiADi
{
    public partial class AreasModificar : Form
    {
        public AreasModificar()
        {
            InitializeComponent();
            cargarTabla();
        }

        public void cargarTabla()
        {
            using (var db = new SiADiDB())
            {
                var list = db.Areas.ToList().Select(i => new { i.Nombre, i.Descripcion }).ToArray();

                if (list.Length > 0)
                {
                    dataGridViewAreas.AutoGenerateColumns = false;
                    dataGridViewAreas.ColumnCount = 2;
                    dataGridViewAreas.Columns[0].Name = "Nombre";
                    dataGridViewAreas.Columns[0].DataPropertyName = "Nombre";
                    dataGridViewAreas.Columns[1].Name = "Descripcion";
                    dataGridViewAreas.Columns[1].DataPropertyName = "Descripcion";
                    dataGridViewAreas.DataSource = list;
                    dataGridViewAreas.Font = new Font("Myriad Pro Cond", 15.99F);
                    dataGridViewAreas.Refresh();

                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            /*
            MessageBox.Show("Cargo añadido.", "SiADi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.textBoxNombre.Clear();
            this.textBoxSalario.Clear();
            errorProvider1.Clear();
            errorNombre = true;
            errorHorario = true;
            errorSalario = true;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new SiADiDB())
            {
                var list = db.Areas.ToList().Where(p => p.Nombre == textBoxFiltro.Text).Select(i => new { i.Nombre, i.Descripcion }).ToArray();

                if (list.Length > 0)
                {
                    dataGridViewAreas.AutoGenerateColumns = false;
                    dataGridViewAreas.DataSource = list;
                    dataGridViewAreas.Refresh();
                }
            }
        }
    }
}
