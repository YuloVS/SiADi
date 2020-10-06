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
                        dataGridViewCargos.ColumnCount = 2;
                        dataGridViewCargos.Columns[0].Name = "Nombre";
                        dataGridViewCargos.Columns[0].DataPropertyName = "Nombre";
                        dataGridViewCargos.Columns[1].Name = "Descripcion";
                        dataGridViewCargos.Columns[1].DataPropertyName = "Descripcion";
                        dataGridViewCargos.DataSource = list;
                        dataGridViewCargos.Font = new Font("Myriad Pro Cond", 15.99F);
                        dataGridViewCargos.Refresh();

                    }
                }
                else
                {
                    var list = db.Areas.ToList().Select(i => new { i.Nombre, i.Descripcion }).ToArray();
                    if (list.Length > 0)
                    {
                        dataGridViewCargos.AutoGenerateColumns = false;
                        dataGridViewCargos.ColumnCount = 2;
                        dataGridViewCargos.Columns[0].Name = "Nombre";
                        dataGridViewCargos.Columns[0].DataPropertyName = "Nombre";
                        dataGridViewCargos.Columns[1].Name = "Descripcion";
                        dataGridViewCargos.Columns[1].DataPropertyName = "Descripcion";
                        dataGridViewCargos.DataSource = list;
                        dataGridViewCargos.Font = new Font("Myriad Pro Cond", 15.99F);
                        dataGridViewCargos.Refresh();

                    }
                }
                
            }
        }
    }
}
