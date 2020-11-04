﻿using System;
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
                var consulta = from a in db.Asistencias
                    where a.PersonaId == personaId
                    select new { a.Hora };
                var list = consulta.ToArray();;
                chartIngreso.DataSource = list;
                chartIngreso.Series.Clear();
                chartIngreso.Series.Add("Horario de entrada");
                chartIngreso.Series["Horario de entrada"].ChartType = SeriesChartType.Point;
                //chartIngreso.Series[0].Label = "#VALY";
                //chartIngreso.Series[0].LabelForeColor = Color.White;
                chartIngreso.Series["Horario de entrada"].XValueMember = "Hora";
                chartIngreso.Series["Horario de entrada"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
                chartIngreso.Series["Horario de entrada"].YValueMembers = "Hora";
                chartIngreso.Series["Horario de entrada"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            }
        }
        
        private void cargarPieChart(int personaId)
        {
            using (var db = new SiADiDB())
            {
                var consulta = from a in db.Asistencias
                    where a.PersonaId == personaId && a.Tipo
                    orderby a.Fecha descending 
                    select a;
                var inicio = 0;
                if (consulta.FirstOrDefault() != null)
                {
                    inicio = Math.Abs((consulta.FirstOrDefault().Fecha - DateTime.Today).Days);
                }
                var list = consulta.ToArray();
                int asistencias = list.Length;
                int faltas;
                if (inicio-asistencias >= 0)
                {
                    faltas = inicio - asistencias;
                }
                else
                {
                    faltas = 0;
                }
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
    }
}
