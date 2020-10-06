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
            dataGridViewCargos.ColumnCount = 5;
            cargarTabla();
        }

        public void cargarTabla()
        {
            using (var db = new SiADiDB())
            {
                if(!admin)
                {
                    Cargo cargo = usuario.Cargo;
                    Area area =  db.Areas.SqlQuery("SELECT * FROM Areas a INNER JOIN Cargos ON a.Id = Cargos.Area_Id WHERE Cargos.Id=@id", new SqlParameter("@id", cargo.Id)).Single();
                    var list = db.Cargos.SqlQuery("SELECT * FROM Cargos c INNER JOIN Areas a ON c.Area_Id = a.Id WHERE a.Id=@id", new SqlParameter("@id", area.Id)).ToArray();
                    if (list.Length > 0)
                    {
                        dataGridViewCargos.AutoGenerateColumns = false;
                        dataGridViewCargos.Columns[0].Name = "Nombre";
                        dataGridViewCargos.Columns[0].DataPropertyName = "Nombre";
                        dataGridViewCargos.Columns[1].Name = "Salario";
                        dataGridViewCargos.Columns[1].DataPropertyName = "Salario";
                        dataGridViewCargos.Columns[2].Name = "Entrada";
                        dataGridViewCargos.Columns[2].DataPropertyName = "Horario_entrada";
                        dataGridViewCargos.Columns[3].Name = "Salida";
                        dataGridViewCargos.Columns[3].DataPropertyName = "Horario_salida";
                        dataGridViewCargos.Columns[4].Name = "Area";
                        dataGridViewCargos.Columns[4].DataPropertyName = "Area_Id";
                        dataGridViewCargos.DataSource = list;
                        dataGridViewCargos.Font = new Font("Myriad Pro Cond", 15.99F);
                        dataGridViewCargos.Refresh();

                    }
                }
                else
                {
                    var list = db.Cargos.SqlQuery("SELECT * FROM Cargos c INNER JOIN Areas a ON c.Area_Id = a.Id").ToArray();
                    if (list.Length > 0)
                    {
                        dataGridViewCargos.AutoGenerateColumns = false;
                        dataGridViewCargos.Columns[0].Name = "Nombre";
                        dataGridViewCargos.Columns[0].DataPropertyName = "Nombre";
                        dataGridViewCargos.Columns[1].Name = "Salario";
                        dataGridViewCargos.Columns[1].DataPropertyName = "Salario";
                        dataGridViewCargos.Columns[2].Name = "Entrada";
                        dataGridViewCargos.Columns[2].DataPropertyName = "Horario_entrada";
                        dataGridViewCargos.Columns[3].Name = "Salida";
                        dataGridViewCargos.Columns[3].DataPropertyName = "Horario_salida";
                        dataGridViewCargos.Columns[4].Name = "Area";
                        dataGridViewCargos.Columns[4].DataPropertyName = "Area_Id";
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
                    Area area = db.Areas.SqlQuery("SELECT * FROM Areas a INNER JOIN Cargos ON a.Id = Cargos.Area_Id WHERE Cargos.Id=@id", new SqlParameter("@id", cargo.Id)).Single();
                    var list = db.Cargos.SqlQuery("SELECT * FROM Cargos c INNER JOIN Areas a ON c.Area_Id = a.Id WHERE a.Id=@id AND c.Nombre=@nombre", new SqlParameter("@id", area.Id), new SqlParameter("@nombre", textBoxFiltro.Text)).ToArray();
                    if (list.Length > 0)
                    {
                        dataGridViewCargos.AutoGenerateColumns = false;
                        dataGridViewCargos.DataSource = list;
                        dataGridViewCargos.Refresh();
                    }
                }
                else
                {
                    var list = db.Cargos.SqlQuery("SELECT * FROM Cargos c INNER JOIN Areas a ON c.Area_Id = a.Id WHERE c.Nombre=@nombre", new SqlParameter("@nombre", textBoxFiltro.Text)).ToArray();
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

        
    }
}
