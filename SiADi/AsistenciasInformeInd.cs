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
    public partial class AsistenciasInformeInd : Form
    {
        public AsistenciasInformeInd()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
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
