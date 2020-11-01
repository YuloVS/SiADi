using SiADi.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiADi
{
    public partial class AreasAñadir : Form
    {
        private Verificaciones verificaciones = new Verificaciones();
        private int error = 1;
        private Area area = null;
        public AreasAñadir()
        {
            InitializeComponent();
            buttonEditar.Hide();
            buttonCancelar.Hide();
            buttonEliminar.Hide();
        }

        public AreasAñadir(Area pArea)
        {
            InitializeComponent();
            area = pArea;
            LabelAreasAñadir.Text = "Modificar Area";
            this.CenterToScreen();
            TextboxNombreAreasAñadir.Text = area.Nombre;
            TextboxDescipcionAreasAñadir.Text = area.Descripcion;
            btnCrear.Hide();
            btnLimpiar.Hide();
        }

        private void TextboxNombreAreasAñadir_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificaciones.soloLetras(e);
        }

        private void TextboxDescipcionAreasAñadir_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificaciones.soloLetras(e);
        }

        private void TextboxNombreAreasAñadir_Validated(object sender, EventArgs e)
        {
            if (TextboxNombreAreasAñadir.TextLength < 3)
            {
                errorProvider1.SetError(TextboxNombreAreasAñadir, "Ingrese un nombre válido.");
                error = 1;
                verificaciones.bordeError(TextboxNombreAreasAñadir, this);
            }
            else
            {
                errorProvider1.Clear();
                error = 0;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.TextboxNombreAreasAñadir.Clear();
            this.TextboxDescipcionAreasAñadir.Clear();
            errorProvider1.Clear();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if(error == 0)
            {
                using (var db = new SiADiDB())
                {
                    db.Areas.Add(new Area { Nombre = TextboxNombreAreasAñadir.Text, Descripcion = TextboxDescipcionAreasAñadir.Text });
                    db.SaveChanges();
                }
                MessageBox.Show("Area añadida.", "SiADi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.TextboxNombreAreasAñadir.Clear();
                this.TextboxDescipcionAreasAñadir.Clear();
                errorProvider1.Clear();
                error = 1;
            }
            else
            {
                MessageBox.Show("Error, verifique el campo 'Nombre'.", "SiADi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (error == 0)
            {
                using (var db = new SiADiDB())
                {
                    var query = from a in db.Areas
                                where a.Id == area.Id
                                select a;
                    foreach (var tArea in query)
                    {
                        tArea.Nombre = TextboxNombreAreasAñadir.Text;
                        tArea.Descripcion = TextboxDescipcionAreasAñadir.Text;
                    }
                    db.SaveChanges();
                    MessageBox.Show("El área ha sido modificada.", "SiADi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
                this.TextboxNombreAreasAñadir.Clear();
                this.TextboxDescipcionAreasAñadir.Clear();
                errorProvider1.Clear();
                error = 1;
            }
            else
            {
                MessageBox.Show("Error, verifique el campo 'Nombre'.", "SiADi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            using (var db = new SiADiDB())
            {
                var query = from a in db.Areas
                            where a.Id == area.Id
                            select a;
                foreach (var tArea in query)
                {
                    tArea.baja = true;
                }
                db.SaveChanges();
                MessageBox.Show("El área ha sido dada de baja.", "SiADi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }
    }
}
