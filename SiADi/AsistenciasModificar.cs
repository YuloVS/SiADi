using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiADi.Modelo;

namespace SiADi
{
    public partial class AsistenciasModificar : Form
    {
        private Persona usuario;
        private bool admin;
        public AsistenciasModificar(Persona persona, bool esAdmin)
        {
            InitializeComponent();
            usuario = persona;
            admin = esAdmin;
            dataGridView1.ColumnCount = 6;
            cargarTabla();
            dataGridView1.Columns["Id"].Visible = false;
        }
        
        public void cargarTabla()
        {
            using (var db = new SiADiDB())
            {
                if (!admin)
                {
                    int id = usuario.Cargo.AreaId;
                    var consulta = from p in db.Personas
                                   join c in db.Cargos on p.Cargo.Id equals c.Id
                                   where p.baja != true && id == c.Area.Id
                                   select new { Id = p.Id, Cuil = p.Cuil, Nombre = p.Nombre, Apellido = p.Apellido, cNombre = c.Nombre, Telefono = p.Telefono };
                    var list = consulta.ToArray();
                    if (list.Length > 0)
                    {
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.Columns[0].Name = "Id";
                        dataGridView1.Columns[0].DataPropertyName = "Id";
                        dataGridView1.Columns[1].Name = "Cuil";
                        dataGridView1.Columns[1].DataPropertyName = "Cuil";
                        dataGridView1.Columns[2].Name = "Nombre";
                        dataGridView1.Columns[2].DataPropertyName = "Nombre";
                        dataGridView1.Columns[3].Name = "Apellido";
                        dataGridView1.Columns[3].DataPropertyName = "Apellido";
                        dataGridView1.Columns[4].Name = "Cargo";
                        dataGridView1.Columns[4].DataPropertyName = "cNombre";
                        dataGridView1.Columns[5].Name = "Telefono";
                        dataGridView1.Columns[5].DataPropertyName = "Telefono";
                        dataGridView1.DataSource = list;
                        dataGridView1.Font = new Font("Myriad Pro Cond", 15.99F);
                        dataGridView1.Refresh();
                    }
                }
                else
                {
                    var consulta = from a in db.Asistencias
                                   join p in db.Personas on a.PersonaId equals p.Id
                                   orderby a.Hora descending 
                                   where p.baja != true
                                   select new { Id = p.Id, Nombre = p.Nombre, Apellido = p.Apellido, a.Fecha, a.Hora, a.Tipo };
                    var list = consulta.ToArray();
                    if (list.Length > 0)
                    {
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.Columns[0].Name = "Id";
                        dataGridView1.Columns[0].DataPropertyName = "Id";
                        dataGridView1.Columns[1].Name = "Nombre";
                        dataGridView1.Columns[1].DataPropertyName = "Nombre";
                        dataGridView1.Columns[2].Name = "Apellido";
                        dataGridView1.Columns[2].DataPropertyName = "Apellido";
                        dataGridView1.Columns[3].Name = "Fecha";
                        dataGridView1.Columns[3].DataPropertyName = "Fecha";
                        dataGridView1.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                        dataGridView1.Columns[4].Name = "Hora";
                        dataGridView1.Columns[4].DataPropertyName = "Hora";
                        dataGridView1.Columns[4].DefaultCellStyle.Format = "HH:mm:ss";
                        dataGridView1.Columns[5].Name = "Tipo";
                        dataGridView1.Columns[5].DataPropertyName = "Tipo";
                        dataGridView1.DataSource = list;
                        dataGridView1.Font = new Font("Myriad Pro Cond", 15.99F);
                        dataGridView1.Refresh();
                    }
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (grid.Columns[e.ColumnIndex].Name == "Tipo")
            {
                e.Value = (bool)e.Value ? "Entrada" : "Salida";
                e.FormattingApplied = true;
            }
        }
    }
}
