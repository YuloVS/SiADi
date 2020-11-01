using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using SiADi.Modelo;

namespace SiADi
{
    public partial class UsuariosModificar : Form
    {
        Persona usuario;
        bool admin;
        public UsuariosModificar(Persona persona, bool esAdmin)
        {
            InitializeComponent();
            usuario = persona;
            admin = esAdmin;
            dataGridView1.ColumnCount = 6;
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
                    var consulta = from p in db.Personas
                                   join c in db.Cargos on p.Cargo.Id equals c.Id
                                   where p.baja != true
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
            }
        }
        
        private void filtrar()
        {
            using (var db = new SiADiDB())
            {
                long.TryParse(textBoxFiltro.Text, out long textNum);
                var consulta = from p in db.Personas
                    join c in db.Cargos on p.Cargo.Id equals c.Id
                    where p.Cuil == textNum || p.Nombre.Contains(textBoxFiltro.Text) || p.Apellido.Contains(textBoxFiltro.Text) || c.Nombre.Contains(textBoxFiltro.Text) || p.Telefono == textNum 
                    select new {Id = p.Id, Cuil = p.Cuil, Nombre = p.Nombre, Apellido = p.Apellido, cNombre = c.Nombre, Telefono = p.Telefono};
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
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int fila = dataGridView1.CurrentRow.Index;
                int idUsuario = (int)dataGridView1.Rows[fila].Cells[0].Value;
                using (var db = new SiADiDB())
                {
                    Persona usuario = db.Personas.Find(idUsuario);
                    Form modificarUsuario = new UsuariosAñadir(this.usuario, admin, usuario);
                    modificarUsuario.Show();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.textBoxFiltro.Clear();
            cargarTabla();
        }
    }
}
