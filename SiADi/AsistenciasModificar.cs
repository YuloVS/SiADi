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
                    var consulta = from a in db.Asistencias
                                   join p in db.Personas on a.PersonaId equals p.Id
                                   orderby a.Hora descending
                                   where p.baja != true && a.baja != true && p.Cargo.AreaId == usuario.Cargo.AreaId
                                   select new { Id = a.Id, Nombre = p.Nombre, Apellido = p.Apellido, a.Fecha, a.Hora, a.Tipo };
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
                else
                {
                    var consulta = from a in db.Asistencias
                                   join p in db.Personas on a.PersonaId equals p.Id
                                   orderby a.Hora descending 
                                   where a.baja != true && p.baja != true
                                   select new { Id = a.Id, Nombre = p.Nombre, Apellido = p.Apellido, a.Fecha, a.Hora, a.Tipo };
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

        private void filtrar()
        {
            using (var db = new SiADiDB())
            {
                if (admin)
                {
                    long.TryParse(textBoxFiltro.Text, out long textNum);
                    var consulta = from a in db.Asistencias
                                   join p in db.Personas on a.PersonaId equals p.Id
                                   where a.Persona.Nombre.Contains(textBoxFiltro.Text) || a.Persona.Apellido.Contains(textBoxFiltro.Text)
                                   select new { Id = a.Id, Nombre = p.Nombre, Apellido = p.Apellido, a.Fecha, a.Hora, a.Tipo };
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
                else
                {
                    long.TryParse(textBoxFiltro.Text, out long textNum);
                    var consulta = from a in db.Asistencias
                                   join p in db.Personas on a.PersonaId equals p.Id
                                   where (a.Persona.Nombre.Contains(textBoxFiltro.Text) || a.Persona.Apellido.Contains(textBoxFiltro.Text)) && p.Cargo.AreaId == usuario.Cargo.AreaId
                                   select new { Id = a.Id, Nombre = p.Nombre, Apellido = p.Apellido, a.Fecha, a.Hora, a.Tipo };
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentRow.Index;
            int idAsistencia = (int)dataGridView1.Rows[fila].Cells[0].Value;
            using (var db = new SiADiDB())
            {
                Asistencia asistencia = db.Asistencias.Find(idAsistencia);
                Form editarAsistencia = new AsistenciasEditar(usuario, admin, asistencia);
                editarAsistencia.Show();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.textBoxFiltro.Clear();
            cargarTabla();
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
