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
            dataGridViewAreas.ColumnCount = 3;
            cargarTabla();
            dataGridViewAreas.Columns["Id"].Visible = false;
        }

        public void cargarTabla()
        {
            using (var db = new SiADiDB())
            {
                var list = db.Areas.ToList().Where(p => !p.baja).Select(i => new { i.Id, i.Nombre, i.Descripcion }).ToArray();
                //var list = db.Areas.ToList().Select(i => new { i.Id, i.Nombre, i.Descripcion }).ToArray();
                //var list = db.Cargos.SqlQuery("SELECT * FROM Cargos c INNER JOIN Areas a ON c.Area_Id = a.Id WHERE a.Id=@id", new SqlParameter("@id", area.Id)).ToArray();

                if (list.Length > 0)
                {
                    dataGridViewAreas.AutoGenerateColumns = false;
                    dataGridViewAreas.Columns[0].Name = "Id";
                    dataGridViewAreas.Columns[0].DataPropertyName = "Id";
                    dataGridViewAreas.Columns[1].Name = "Nombre";
                    dataGridViewAreas.Columns[1].DataPropertyName = "Nombre";
                    dataGridViewAreas.Columns[2].Name = "Descripcion";
                    dataGridViewAreas.Columns[2].DataPropertyName = "Descripcion";
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

        private void filtrar()
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            filtrar();
        }

        private void textBoxFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                filtrar();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.textBoxFiltro.Clear();
            cargarTabla();
        }

        private void dataGridViewAreas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridViewAreas.CurrentRow.Index;
            int idArea= (int)dataGridViewAreas.Rows[fila].Cells[0].Value;
            using (var db = new SiADiDB())
            {
                Area area = db.Areas.Find(idArea);
                Form modificarArea = new AreasAñadir(area);
                modificarArea.Show();
            }
        }
    }
}
