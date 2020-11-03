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
    public partial class AsistenciasEditar : Form
    {
        private Verificaciones verificaciones = new Verificaciones();
        private Persona usuario;
        private bool admin;
        private Asistencia asistencia;
        public AsistenciasEditar(Persona persona, bool esAdmin, Asistencia pAsistencia)
        {
            InitializeComponent();
            usuario = persona;
            admin = esAdmin;
            asistencia = pAsistencia;
            this.CenterToScreen();
            textBoxNombre.Text = asistencia.Persona.Nombre;
            textBoxApellido.Text = asistencia.Persona.Apellido;
            horarioAsistencia.Value = asistencia.Hora;
            fechaAsistencia.Value = asistencia.Hora;
            if (asistencia.Tipo)
            {
                radioButtonEntrada.Checked = true;
            }
            else
            {
                radioButtonSalida.Checked = true;
            }
        }
        
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            using (var db = new SiADiDB())
            {
                var query = from a in db.Asistencias
                            where a.Id == asistencia.Id
                            select a;
                foreach (var tAsistencia in query)
                {
                    tAsistencia.baja = true;
                }
                db.SaveChanges();
                MessageBox.Show("La asistencia ha sido dado de baja.", "SiADi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

        }
    }
}

