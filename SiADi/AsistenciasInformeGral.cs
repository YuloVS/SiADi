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
    public partial class AsistenciasInformeGral : Form
    {
        public AsistenciasInformeGral()
        {
            InitializeComponent();
        }

        private void AsistenciasInformeGral_Load(object sender, EventArgs e)
        {
            cargarChart();
            ingresos();
            egresos();
            faltas();
            tardanzas();
        }

        private void ingresos()
        {
            using (var db = new SiADiDB())
            {
                var consulta = from a in db.Asistencias where a.Fecha.Equals(DateTime.Today) && a.Tipo select new {a.Id};
                labelIngresosCantidad.Text = consulta.Count().ToString();
            }
        }
        
        private void egresos()
        {
            using (var db = new SiADiDB())
            {
                var consulta = from a in db.Asistencias where a.Fecha.Equals(DateTime.Today) && !a.Tipo select new {a.Id};
                labelEgresosCantidad.Text = consulta.Count().ToString();
            }
        }
        
        private void faltas()
        {
            using (var db = new SiADiDB())
            {
                var asistencias = from a in db.Asistencias where a.Fecha.Equals(DateTime.Today) && !a.baja
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
                var asistencias = from a in db.Asistencias where a.Fecha.Equals(DateTime.Today) && !a.baja
                    join p in db.Personas on a.PersonaId equals p.Id 
                    select new {aHora = a.Hora, cHora = p.Cargo.Horario_entrada};
                //var cero = new TimeSpan(0, 0, 0);
                var tardanzas = from a in asistencias
                    where System.Data.Entity.DbFunctions.DiffMinutes(a.aHora, a.cHora) > 0
                    select new {a.aHora};
                labelTardanzasCantidad.Text = tardanzas.Count().ToString();
            }
        }

        private void cargarChart()
        {
            using (var db = new SiADiDB())
            {
                var consulta = from a in db.Asistencias
                    join p in db.Personas on a.PersonaId equals p.Id
                    group a by a.PersonaId into g
                        //where !p.baja && !a.baja
                    select new {Cantidad = g.Count(), Nombre = g.Select(a => a.Persona.Apellido).FirstOrDefault().ToString() };
                var list = consulta.ToArray();
                chartInformeGral.DataSource = list;
                chartInformeGral.Series.Clear();
                chartInformeGral.Series.Add("Asistencias");
                chartInformeGral.Series[0].Label = "#VALY";
                chartInformeGral.Series[0].LabelForeColor = Color.White;
                chartInformeGral.Series["Asistencias"].XValueMember = "Nombre";
                chartInformeGral.Series["Asistencias"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                chartInformeGral.Series["Asistencias"].YValueMembers = "Cantidad";
                chartInformeGral.Series["Asistencias"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            }
        }
    }
}
