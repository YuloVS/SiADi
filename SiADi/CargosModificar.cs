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
    public partial class CargosModificar : Form
    {
        Persona usuario;
        bool admin;
        public CargosModificar(Persona persona, bool esAdmin)
        {
            InitializeComponent();
            usuario = persona;
            admin = esAdmin;
            dataGridViewCargos.ColumnCount = 6;
            cargarTabla();
            dataGridViewCargos.Columns["Id"].Visible = false;
        }

        public void cargarTabla()
        {
            using (var db = new SiADiDB())
            {
                if(!admin)
                {
                    Cargo cargo = usuario.Cargo;
                    var cargos = from c in db.Cargos where c.AreaId == cargo.AreaId select new { Id = c.Id, Nombre = c.Nombre, Salario = c.Salario, Horario_entrada = c.Horario_entrada, Horario_salida = c.Horario_salida, Area = c.Area.Nombre };
                    var list = cargos.ToArray();
                    if (list.Length > 0)
                    {
                        dataGridViewCargos.AutoGenerateColumns = false;
                        dataGridViewCargos.Columns[0].Name = "Id";
                        dataGridViewCargos.Columns[0].DataPropertyName = "Id";
                        dataGridViewCargos.Columns[1].Name = "Nombre";
                        dataGridViewCargos.Columns[1].DataPropertyName = "Nombre";
                        dataGridViewCargos.Columns[2].Name = "Salario";
                        dataGridViewCargos.Columns[2].DataPropertyName = "Salario";
                        dataGridViewCargos.Columns[3].Name = "Entrada";
                        dataGridViewCargos.Columns[3].DataPropertyName = "Horario_entrada";
                        dataGridViewCargos.Columns[4].Name = "Salida";
                        dataGridViewCargos.Columns[4].DataPropertyName = "Horario_salida";
                        dataGridViewCargos.Columns[5].Name = "Area";
                        dataGridViewCargos.Columns[5].DataPropertyName = "Area";
                        dataGridViewCargos.DataSource = list;
                        dataGridViewCargos.Font = new Font("Myriad Pro Cond", 15.99F);
                        dataGridViewCargos.Refresh();
                    }
                }
                else
                {
                    Cargo cargo = usuario.Cargo;
                    var cargos = from c in db.Cargos select new { Id = c.Id, Nombre = c.Nombre, Salario = c.Salario, Horario_entrada = c.Horario_entrada, Horario_salida = c.Horario_salida, Area = c.Area.Nombre };
                    var list = cargos.ToArray();
                    if (list.Length > 0)
                    {
                        dataGridViewCargos.AutoGenerateColumns = false;
                        dataGridViewCargos.Columns[0].Name = "Id";
                        dataGridViewCargos.Columns[0].DataPropertyName = "Id";
                        dataGridViewCargos.Columns[1].Name = "Nombre";
                        dataGridViewCargos.Columns[1].DataPropertyName = "Nombre";
                        dataGridViewCargos.Columns[2].Name = "Salario";
                        dataGridViewCargos.Columns[2].DataPropertyName = "Salario";
                        dataGridViewCargos.Columns[3].Name = "Entrada";
                        dataGridViewCargos.Columns[3].DataPropertyName = "Horario_entrada";
                        dataGridViewCargos.Columns[4].Name = "Salida";
                        dataGridViewCargos.Columns[4].DataPropertyName = "Horario_salida";
                        dataGridViewCargos.Columns[5].Name = "Area";
                        dataGridViewCargos.Columns[5].DataPropertyName = "Area";
                        dataGridViewCargos.DataSource = list;
                        dataGridViewCargos.Font = new Font("Myriad Pro Cond", 15.99F);
                        dataGridViewCargos.Refresh();

                    }
                }
                
            }
        }

        private void filtrar()
        {
            using (var db = new SiADiDB())
            {
                if (!admin)
                {
                    Cargo cargo = usuario.Cargo;
                    Area area = db.Areas.SqlQuery("SELECT * FROM Areas a INNER JOIN Cargos ON a.Id = Cargos.AreaId WHERE Cargos.Id=@id", new SqlParameter("@id", cargo.Id)).Single();
                    var list = db.Cargos.SqlQuery("SELECT * FROM Cargos c INNER JOIN Areas a ON c.AreaId = a.Id WHERE a.Id=@id AND (c.Nombre=@nombre OR c.Salario=@salario)", new SqlParameter("@id", area.Id), new SqlParameter("@nombre", textBoxFiltro.Text), new SqlParameter("@salario", Convert.ToDouble(textBoxFiltro.Text))).ToArray();
                    if (list.Length > 0)
                    {
                        dataGridViewCargos.AutoGenerateColumns = false;
                        dataGridViewCargos.DataSource = list;
                        dataGridViewCargos.Refresh();
                    }
                }
                else
                {
                    var list = db.Cargos.SqlQuery("SELECT * FROM Cargos c INNER JOIN Areas a ON c.AreaId = a.Id WHERE c.Nombre=@nombre OR c.Salario=@salario ", new SqlParameter("@nombre", textBoxFiltro.Text), new SqlParameter("@salario", Convert.ToDouble(textBoxFiltro.Text))).ToArray();
                    if (list.Length > 0)
                    {
                        dataGridViewCargos.AutoGenerateColumns = false;
                        dataGridViewCargos.DataSource = list;
                        dataGridViewCargos.Refresh();
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            filtrar();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            this.textBoxFiltro.Clear();
            cargarTabla();
        }

        private void textBoxFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                filtrar();
            }
        }

        private void dataGridViewCargos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridViewCargos.CurrentRow.Index;
            int idCargo = (int)dataGridViewCargos.Rows[fila].Cells[0].Value; 
            using (var db = new SiADiDB())
            {
                Cargo cargo = db.Cargos.Find(idCargo);
                Form modificarCargos = new CargosAñadir(usuario, admin, cargo);
                modificarCargos.Show();
            }
        }
    }
}
