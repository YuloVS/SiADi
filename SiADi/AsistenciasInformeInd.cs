using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using SiADi.Modelo;

namespace SiADi
{
    public partial class AsistenciasInformeInd : Form
    {
        private Persona usuario;
        private bool admin;
        public AsistenciasInformeInd(Persona usuario, bool esAdmin)
        {
            InitializeComponent();
            this.usuario = usuario;
            admin = esAdmin;
            dataGridView1.ColumnCount = 4;
            cargarTabla();
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Cuil"].ReadOnly = true;
            dataGridView1.Columns["Nombre"].ReadOnly = true;
            dataGridView1.Columns["Apellido"].ReadOnly = true;
        }
        
        public void cargarTabla()
        {
            using (var db = new SiADiDB())
            {
                if (!admin)
                {
                    int id = usuario.Cargo.AreaId;
                    var consulta = from p in db.Personas
                                   where p.baja != true && id == p.Cargo.AreaId
                                   select new { Id = p.Id, Cuil = p.Cuil, Nombre = p.Nombre, Apellido = p.Apellido};
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
                        dataGridView1.DataSource = list;
                        dataGridView1.Font = new Font("Myriad Pro Cond", 15.99F);
                        dataGridView1.Refresh();
                    }
                }
                else
                {
                    var list = db.Personas.ToArray();
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
                        dataGridView1.DataSource = list;
                        dataGridView1.Font = new Font("Myriad Pro Cond", 15.99F);
                        dataGridView1.Refresh();
                    }
                }
            }
        }
        
        private void cargarChartIngreso(int personaId)
        {
            using (var db = new SiADiDB())
            {
                var ingresos = from a in db.Asistencias
                    where a.PersonaId == personaId && a.Tipo
                    select new { a.Hora };
                var ingresosLista = ingresos.ToArray();
                var egresos = from a in db.Asistencias
                    where a.PersonaId == personaId && !a.Tipo
                    select new { a.Hora };
                var egresosLista = egresos.ToArray();
                chartIngreso.DataSource = ingresosLista;
                chartIngreso.Series.Clear();
                chartIngreso.Series.Add("Horario de entrada");
                chartIngreso.Series["Horario de entrada"].ChartType = SeriesChartType.Point;
                chartIngreso.Series["Horario de entrada"].XValueMember = "Hora";
                chartIngreso.Series["Horario de entrada"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
                chartIngreso.Series["Horario de entrada"].YValueMembers = "Hora";
                chartIngreso.Series["Horario de entrada"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
                chartIngreso.Series[0].Color = Color.Green;
                
                chartEgreso.DataSource = egresosLista;
                chartEgreso.Series.Clear();
                chartEgreso.Series.Add("Horario de salida");
                chartEgreso.Series["Horario de salida"].ChartType = SeriesChartType.Point;
                chartEgreso.Series["Horario de salida"].XValueMember = "Hora";
                chartEgreso.Series["Horario de salida"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
                chartEgreso.Series["Horario de salida"].YValueMembers = "Hora";
                chartEgreso.Series["Horario de salida"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
                chartEgreso.Series[0].Color = Color.Red;

            }
        }
        
        private void cargarPieChart(int personaId)
        {
            using (var db = new SiADiDB())
            {
                var consulta = from a in db.Asistencias
                    where a.PersonaId == personaId && a.Tipo
                    orderby a.Fecha descending 
                    group a by a.Fecha into g
                    select g;
                var inicio = 0;
                if (consulta.FirstOrDefault() != null)
                    inicio = Math.Abs((consulta.FirstOrDefault().FirstOrDefault().Fecha - DateTime.Today).Days);
                var list = consulta.ToArray();
                int asistencias = list.Length;
                labelCantidad.Text = asistencias.ToString();
                int faltas;
                if (inicio - asistencias >= 0)
                    faltas = inicio - asistencias;
                else
                    faltas = 0;
                chart1.DataSource = list;
                chart1.Series.Clear();
                chart1.Series.Add("Ingresos");
                chart1.Series["Ingresos"].ChartType = SeriesChartType.Pie;
                chart1.Series[0].Label = "#VAL";
                chart1.Series[0].LegendText = "#AXISLABEL";
                chart1.Series[0].LabelForeColor = Color.White;
                chart1.Series["Ingresos"].Points.AddXY("Asistencias", asistencias);
                chart1.Series[0].Points[0].Color = Color.Green;
                chart1.Series["Ingresos"].Points.AddXY("Faltas", faltas);
                chart1.Series[0].Points[1].Color = Color.Red;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int fila = dataGridView1.CurrentRow.Index;
                int personaId = (int)dataGridView1.Rows[fila].Cells[0].Value;
                cargarChartIngreso(personaId);
                cargarPieChart(personaId);
            }
        }

        private void filtrar()
        {
            using (var db = new SiADiDB())
            {
                if (admin)
                {
                    long.TryParse(textBoxFiltro.Text, out long textNum);
                    var consulta = from p in db.Personas
                                   where p.Cuil == textNum || p.Nombre.Contains(textBoxFiltro.Text) || p.Apellido.Contains(textBoxFiltro.Text) 
                                   select new { Id = p.Id, Cuil = p.Cuil, Nombre = p.Nombre, Apellido = p.Apellido};
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
                        dataGridView1.DataSource = list;
                        dataGridView1.Font = new Font("Myriad Pro Cond", 15.99F);
                        dataGridView1.Refresh();
                    }
                }
                else
                {
                    long.TryParse(textBoxFiltro.Text, out long textNum);
                    var consulta = from p in db.Personas
                                   where (p.Cuil == textNum || p.Nombre.Contains(textBoxFiltro.Text) || p.Apellido.Contains(textBoxFiltro.Text)) && p.Cargo.AreaId == usuario.Cargo.AreaId
                                   select new { Id = p.Id, Cuil = p.Cuil, Nombre = p.Nombre, Apellido = p.Apellido};
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
                        dataGridView1.DataSource = list;
                        dataGridView1.Font = new Font("Myriad Pro Cond", 15.99F);
                        dataGridView1.Refresh();
                    }
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

        private void refresh_Click(object sender, EventArgs e)
        {
            this.textBoxFiltro.Clear();
            cargarTabla();
        }
    }
}
