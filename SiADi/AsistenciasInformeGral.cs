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
    public partial class AsistenciasInformeGral : Form
    {
        private Persona usuario;
        private bool admin;

        public AsistenciasInformeGral(Persona usuario, bool esAdmin)
        {
            InitializeComponent();
            this.usuario = usuario;
            admin = esAdmin;
            dataGridView1.ColumnCount = 4;
            cargarTabla();
        }

        private void AsistenciasInformeGral_Load(object sender, EventArgs e)
        {
            cargarChart();
            cargarPieChart();
            ingresos();
            egresos();
            //faltas();
            //tardanzas();
        }

        private void ingresos()
        {
            using (var db = new SiADiDB())
            {
                if (admin)
                {
                    var consulta = from a in db.Asistencias
                                   where a.Fecha.Equals(DateTime.Today) && a.Tipo 
                                   select new { a.Id };
                    labelIngresosCantidad.Text = consulta.Count().ToString();
                }
                else 
                {
                    var consulta = from a in db.Asistencias
                                   where a.Fecha.Equals(DateTime.Today) && a.Tipo && a.Persona.Cargo.AreaId == usuario.Cargo.AreaId
                                   select new { a.Id };
                    labelIngresosCantidad.Text = consulta.Count().ToString();
                }
            }
        }

        private void egresos()
        {
            using (var db = new SiADiDB())
            {
                if (admin)
                {
                    var consulta = from a in db.Asistencias
                                   where a.Fecha.Equals(DateTime.Today) && !a.Tipo
                                   select new { a.Id };
                    labelEgresosCantidad.Text = consulta.Count().ToString();
                }
                else
                {
                    var consulta = from a in db.Asistencias
                                   where a.Fecha.Equals(DateTime.Today) && !a.Tipo && a.Persona.Cargo.AreaId == usuario.Cargo.AreaId
                                   select new { a.Id };
                    labelEgresosCantidad.Text = consulta.Count().ToString();
                }
            }
        }

        private void faltas()
        {
            using (var db = new SiADiDB())
            {
                var asistencias = from a in db.Asistencias
                    where a.Fecha.Equals(DateTime.Today) && !a.baja
                    join p in db.Personas on a.PersonaId equals p.Id
                    select new {a.Id};
                var personas = db.Personas.Where(p => !p.baja);
                labelFaltasCantidad.Text = (personas.Count() - asistencias.Count()).ToString();
            }
        }

        private void tardanzas()
        {
            using (var db = new SiADiDB())
            {
                var asistencias = from a in db.Asistencias
                    where a.Fecha.Equals(DateTime.Today) && !a.baja
                    join p in db.Personas on a.PersonaId equals p.Id
                    select new {aHora = a.Hora, cHora = p.Cargo.Horario_entrada};
                //var cero = new TimeSpan(0, 0, 0);
                var tardanzas = from a in asistencias
                    where System.Data.Entity.DbFunctions.DiffMinutes(a.aHora, a.cHora) > 0
                    select new {a.aHora};
                //labelTardanzasCantidad.Text = tardanzas.Count().ToString();
            }
        }

        private void cargarChart()
        {
            using (var db = new SiADiDB())
            {
                if (admin)
                {
                    var consulta = from a in db.Asistencias
                                   where System.Data.Entity.DbFunctions.DiffDays(a.Fecha, DateTime.Today) == 0 
                                   group a by a.Persona into g
                                   select new { Nombre = g.Select(a => a.Persona.Nombre).FirstOrDefault() + " " + g.Select(a => a.Persona.Apellido).FirstOrDefault(), Hora = g.Select(a => a.Hora).FirstOrDefault() };
                    var list = consulta.ToArray();
                    chartInformeGral.DataSource = list;
                    chartInformeGral.Series.Clear();
                    chartInformeGral.Series.Add("Horario de entrada");
                    chartInformeGral.Series["Horario de entrada"].ChartType = SeriesChartType.Point;
                    chartInformeGral.Series[0].Label = "#VALY";
                    chartInformeGral.Series[0].LabelForeColor = Color.White;
                    chartInformeGral.Series["Horario de entrada"].XValueMember = "Nombre";
                    chartInformeGral.Series["Horario de entrada"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                    chartInformeGral.Series["Horario de entrada"].YValueMembers = "Hora";
                    chartInformeGral.Series["Horario de entrada"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
                }
                else 
                {
                    var consulta = from a in db.Asistencias
                                   where System.Data.Entity.DbFunctions.DiffDays(a.Fecha, DateTime.Today) == 0 && a.Persona.Cargo.AreaId == usuario.Cargo.AreaId
                                   group a by a.Persona into g
                                   select new { Nombre = g.Select(a => a.Persona.Nombre).FirstOrDefault() + " " + g.Select(a => a.Persona.Apellido).FirstOrDefault(), Hora = g.Select(a => a.Hora).FirstOrDefault() };
                    var list = consulta.ToArray();
                    chartInformeGral.DataSource = list;
                    chartInformeGral.Series.Clear();
                    chartInformeGral.Series.Add("Horario de entrada");
                    chartInformeGral.Series["Horario de entrada"].ChartType = SeriesChartType.Point;
                    chartInformeGral.Series[0].Label = "#VALY";
                    chartInformeGral.Series[0].LabelForeColor = Color.White;
                    chartInformeGral.Series["Horario de entrada"].XValueMember = "Nombre";
                    chartInformeGral.Series["Horario de entrada"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                    chartInformeGral.Series["Horario de entrada"].YValueMembers = "Hora";
                    chartInformeGral.Series["Horario de entrada"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
                }
            }
        }
        
        private void cargarPieChart()
        {
            using (var db = new SiADiDB())
            {
                if (admin)
                {
                    var consulta = from a in db.Asistencias
                                   where System.Data.Entity.DbFunctions.DiffDays(a.Fecha, DateTime.Today) == 0
                                   group a by a.Persona into g
                                   select new { Nombre = g.Select(a => a.Persona.Nombre).FirstOrDefault() + " " + g.Select(a => a.Persona.Apellido).FirstOrDefault(), Hora = g.Select(a => a.Hora).FirstOrDefault() };
                    var list = consulta.ToArray();
                    int asistieron = list.Length;
                    int noAsistieron = db.Personas.Count() - asistieron;
                    chart1.DataSource = list;
                    chart1.Series.Clear();
                    chart1.Series.Add("Ingresos");
                    chart1.Series["Ingresos"].ChartType = SeriesChartType.Pie;
                    chart1.Series[0].Label = "#VAL";
                    chart1.Series[0].LegendText = "#AXISLABEL";
                    chart1.Series[0].LabelForeColor = Color.White;
                    chart1.Series["Ingresos"].Points.AddXY("Presentes", asistieron);
                    chart1.Series[0].Points[0].Color = Color.Green;
                    chart1.Series["Ingresos"].Points.AddXY("Ausentes", noAsistieron);
                    chart1.Series[0].Points[1].Color = Color.Red;
                }
                else
                {
                    var consulta = from a in db.Asistencias
                                   where System.Data.Entity.DbFunctions.DiffDays(a.Fecha, DateTime.Today) == 0 && a.Persona.Cargo.AreaId == usuario.Cargo.AreaId
                                   group a by a.Persona into g
                                   select new { Nombre = g.Select(a => a.Persona.Nombre).FirstOrDefault() + " " + g.Select(a => a.Persona.Apellido).FirstOrDefault(), Hora = g.Select(a => a.Hora).FirstOrDefault() };
                    var list = consulta.ToArray();
                    int asistieron = list.Length;
                    int noAsistieron = db.Personas.Count() - asistieron;
                    chart1.DataSource = list;
                    chart1.Series.Clear();
                    chart1.Series.Add("Ingresos");
                    chart1.Series["Ingresos"].ChartType = SeriesChartType.Pie;
                    chart1.Series[0].Label = "#VAL";
                    chart1.Series[0].LegendText = "#AXISLABEL";
                    chart1.Series[0].LabelForeColor = Color.White;
                    chart1.Series["Ingresos"].Points.AddXY("Presentes", asistieron);
                    chart1.Series[0].Points[0].Color = Color.Green;
                    chart1.Series["Ingresos"].Points.AddXY("Ausentes", noAsistieron);
                    chart1.Series[0].Points[1].Color = Color.Red;
                }
            }
        }
        
        public void cargarTabla()
        {
            using (var db = new SiADiDB())
            {
                if (!admin)
                {
                    var consulta = from p in db.Personas
                                   join a in db.Asistencias on p.Id equals a.PersonaId
                                   where p.baja != true && !a.baja && System.Data.Entity.DbFunctions.DiffDays(a.Fecha, DateTime.Today) == 0 && a.Persona.Cargo.AreaId == usuario.Cargo.AreaId
                                   select p;
                    var ausentes = db.Personas.Where(p => p.Cargo.AreaId == usuario.Cargo.AreaId).Except(consulta).Select(p => new { Cuil = p.Cuil, Nombre = p.Nombre, Apellido = p.Apellido, Entrada = p.Cargo.Horario_entrada });
                    var list = ausentes.ToArray();
                    labelFaltasCantidad.Text = list.Length.ToString();
                    if (list.Length > 0)
                    {
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.Columns[0].Name = "Cuil";
                        dataGridView1.Columns[0].DataPropertyName = "Cuil";
                        dataGridView1.Columns[1].Name = "Nombre";
                        dataGridView1.Columns[1].DataPropertyName = "Nombre";
                        dataGridView1.Columns[2].Name = "Apellido";
                        dataGridView1.Columns[2].DataPropertyName = "Apellido";
                        dataGridView1.Columns[3].Name = "Entrada";
                        dataGridView1.Columns[3].DataPropertyName = "Entrada";
                        dataGridView1.DataSource = list;
                        dataGridView1.Font = new Font("Myriad Pro Cond", 15.99F);
                        dataGridView1.Refresh();
                    }
                }
                else
                {
                    var consulta = from p in db.Personas
                        join a in db.Asistencias on p.Id equals a.PersonaId
                        where p.baja != true && !a.baja && System.Data.Entity.DbFunctions.DiffDays(a.Fecha, DateTime.Today) == 0
                        select p;
                    var ausentes = db.Personas.Except(consulta).Select(p => new { Cuil = p.Cuil, Nombre = p.Nombre, Apellido = p.Apellido, Entrada = p.Cargo.Horario_entrada } );
                    var list = ausentes.ToArray();
                    labelFaltasCantidad.Text = list.Length.ToString();
                    if (list.Length > 0)
                    {
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.Columns[0].Name = "Cuil";
                        dataGridView1.Columns[0].DataPropertyName = "Cuil";
                        dataGridView1.Columns[1].Name = "Nombre";
                        dataGridView1.Columns[1].DataPropertyName = "Nombre";
                        dataGridView1.Columns[2].Name = "Apellido";
                        dataGridView1.Columns[2].DataPropertyName = "Apellido";
                        dataGridView1.Columns[3].Name = "Entrada";
                        dataGridView1.Columns[3].DataPropertyName = "Entrada";
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
                    var consulta = from p in db.Personas
                                   where p.Cuil == textNum || p.Nombre.Contains(textBoxFiltro.Text) || p.Apellido.Contains(textBoxFiltro.Text)
                                   select new { Id = p.Id, Cuil = p.Cuil, Nombre = p.Nombre, Apellido = p.Apellido };
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
                                   select new { Id = p.Id, Cuil = p.Cuil, Nombre = p.Nombre, Apellido = p.Apellido };
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
