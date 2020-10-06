using SiADi.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiADi
{
    public partial class Principal : Form
    {
        Persona usuario;
        bool admin;
        public Principal(Persona persona, bool esAdmin)
        {
            InitializeComponent();
            hideSubMenu();
            usuario = persona;
            admin = esAdmin;
            vista_admin(esAdmin);
        }

        private void vista_admin(bool esAdmin)
        {
            if(!esAdmin)
            {
                btnAreas.Hide();
            }
        }

        private void hideSubMenu()
        {
            panelAsistenciasSubMenu.Visible = false;
            panelUsuariosSubMenu.Visible = false;
            panelCargosSubMenu.Visible = false;
            panelAreasSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
       
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void botonSeleccionado(Button b)
        {
            if (b == btnAsistenciasRegistrar)
            {
                b.BackColor = Color.FromArgb(235, 42, 83);
                btnAsistenciasModificar.BackColor = Color.FromArgb(35, 32, 39);
                btnAsistenciasInformeGral.BackColor = Color.FromArgb(35, 32, 39);
                btnAsistenciasInformeInd.BackColor = Color.FromArgb(35, 32, 39);
                btnUsuariosAñadir.BackColor = Color.FromArgb(35, 32, 39);
                btnUsuariosModificar.BackColor = Color.FromArgb(35, 32, 39);
                btnCargosAñadir.BackColor = Color.FromArgb(35, 32, 39);
                btnCargosModificar.BackColor = Color.FromArgb(35, 32, 39);
                btnAreasAñadir.BackColor = Color.FromArgb(35, 32, 39);
                btnAreasModificar.BackColor = Color.FromArgb(35, 32, 39);
            }
            else if (b == btnAsistenciasModificar)
            {
                b.BackColor = Color.FromArgb(235, 42, 83);
                btnAsistenciasRegistrar.BackColor = Color.FromArgb(35, 32, 39);
                btnAsistenciasInformeGral.BackColor = Color.FromArgb(35, 32, 39);
                btnAsistenciasInformeInd.BackColor = Color.FromArgb(35, 32, 39);
                btnUsuariosAñadir.BackColor = Color.FromArgb(35, 32, 39);
                btnUsuariosModificar.BackColor = Color.FromArgb(35, 32, 39);
                btnCargosAñadir.BackColor = Color.FromArgb(35, 32, 39);
                btnCargosModificar.BackColor = Color.FromArgb(35, 32, 39);
                btnAreasAñadir.BackColor = Color.FromArgb(35, 32, 39);
                btnAreasModificar.BackColor = Color.FromArgb(35, 32, 39);
            }
            else if (b == btnAsistenciasInformeGral)
            {
                b.BackColor = Color.FromArgb(235, 42, 83);
                btnAsistenciasRegistrar.BackColor = Color.FromArgb(35, 32, 39);
                btnAsistenciasModificar.BackColor = Color.FromArgb(35, 32, 39);
                btnAsistenciasInformeInd.BackColor = Color.FromArgb(35, 32, 39);
                btnUsuariosAñadir.BackColor = Color.FromArgb(35, 32, 39);
                btnUsuariosModificar.BackColor = Color.FromArgb(35, 32, 39);
                btnCargosAñadir.BackColor = Color.FromArgb(35, 32, 39);
                btnCargosModificar.BackColor = Color.FromArgb(35, 32, 39);
                btnAreasAñadir.BackColor = Color.FromArgb(35, 32, 39);
                btnAreasModificar.BackColor = Color.FromArgb(35, 32, 39);
            }
            else if (b == btnAsistenciasInformeInd)
            {
                b.BackColor = Color.FromArgb(235, 42, 83);
                btnAsistenciasRegistrar.BackColor = Color.FromArgb(35, 32, 39);
                btnAsistenciasModificar.BackColor = Color.FromArgb(35, 32, 39);
                btnAsistenciasInformeGral.BackColor = Color.FromArgb(35, 32, 39);
                btnUsuariosAñadir.BackColor = Color.FromArgb(35, 32, 39);
                btnUsuariosModificar.BackColor = Color.FromArgb(35, 32, 39);
                btnCargosAñadir.BackColor = Color.FromArgb(35, 32, 39);
                btnCargosModificar.BackColor = Color.FromArgb(35, 32, 39);
                btnAreasAñadir.BackColor = Color.FromArgb(35, 32, 39);
                btnAreasModificar.BackColor = Color.FromArgb(35, 32, 39);
            }
            else if (b == btnUsuariosAñadir)
            {
                b.BackColor = Color.FromArgb(235, 42, 83);
                btnAsistenciasRegistrar.BackColor = Color.FromArgb(35, 32, 39);
                btnAsistenciasModificar.BackColor = Color.FromArgb(35, 32, 39);
                btnAsistenciasInformeGral.BackColor = Color.FromArgb(35, 32, 39);
                btnAsistenciasInformeInd.BackColor = Color.FromArgb(35, 32, 39);
                btnUsuariosModificar.BackColor = Color.FromArgb(35, 32, 39);
                btnCargosAñadir.BackColor = Color.FromArgb(35, 32, 39);
                btnCargosModificar.BackColor = Color.FromArgb(35, 32, 39);
                btnAreasAñadir.BackColor = Color.FromArgb(35, 32, 39);
                btnAreasModificar.BackColor = Color.FromArgb(35, 32, 39);
            }
            else if (b == btnUsuariosModificar)
            {
                b.BackColor = Color.FromArgb(235, 42, 83);
                btnAsistenciasRegistrar.BackColor = Color.FromArgb(35, 32, 39);
                btnAsistenciasModificar.BackColor = Color.FromArgb(35, 32, 39);
                btnAsistenciasInformeGral.BackColor = Color.FromArgb(35, 32, 39);
                btnAsistenciasInformeInd.BackColor = Color.FromArgb(35, 32, 39);
                btnUsuariosAñadir.BackColor = Color.FromArgb(35, 32, 39);
                btnCargosAñadir.BackColor = Color.FromArgb(35, 32, 39);
                btnCargosModificar.BackColor = Color.FromArgb(35, 32, 39);
                btnAreasAñadir.BackColor = Color.FromArgb(35, 32, 39);
                btnAreasModificar.BackColor = Color.FromArgb(35, 32, 39);
            }
            else if (b == btnCargosAñadir)
            {
                b.BackColor = Color.FromArgb(235, 42, 83);
                btnAsistenciasRegistrar.BackColor = Color.FromArgb(35, 32, 39);
                btnAsistenciasModificar.BackColor = Color.FromArgb(35, 32, 39);
                btnAsistenciasInformeGral.BackColor = Color.FromArgb(35, 32, 39);
                btnAsistenciasInformeInd.BackColor = Color.FromArgb(35, 32, 39);
                btnUsuariosAñadir.BackColor = Color.FromArgb(35, 32, 39);
                btnUsuariosModificar.BackColor = Color.FromArgb(35, 32, 39);
                btnCargosModificar.BackColor = Color.FromArgb(35, 32, 39);
                btnAreasAñadir.BackColor = Color.FromArgb(35, 32, 39);
                btnAreasModificar.BackColor = Color.FromArgb(35, 32, 39);
            }
            else if (b == btnCargosModificar)
            {
                b.BackColor = Color.FromArgb(235, 42, 83);
                btnAsistenciasRegistrar.BackColor = Color.FromArgb(35, 32, 39);
                btnAsistenciasModificar.BackColor = Color.FromArgb(35, 32, 39);
                btnAsistenciasInformeGral.BackColor = Color.FromArgb(35, 32, 39);
                btnAsistenciasInformeInd.BackColor = Color.FromArgb(35, 32, 39);
                btnUsuariosAñadir.BackColor = Color.FromArgb(35, 32, 39);
                btnUsuariosModificar.BackColor = Color.FromArgb(35, 32, 39);
                btnCargosAñadir.BackColor = Color.FromArgb(35, 32, 39);
                btnAreasAñadir.BackColor = Color.FromArgb(35, 32, 39);
                btnAreasModificar.BackColor = Color.FromArgb(35, 32, 39);
            }
            else if (b == btnAreasAñadir)
            {
                b.BackColor = Color.FromArgb(235, 42, 83);
                btnAsistenciasRegistrar.BackColor = Color.FromArgb(35, 32, 39);
                btnAsistenciasModificar.BackColor = Color.FromArgb(35, 32, 39);
                btnAsistenciasInformeGral.BackColor = Color.FromArgb(35, 32, 39);
                btnAsistenciasInformeInd.BackColor = Color.FromArgb(35, 32, 39);
                btnUsuariosAñadir.BackColor = Color.FromArgb(35, 32, 39);
                btnUsuariosModificar.BackColor = Color.FromArgb(35, 32, 39);
                btnCargosAñadir.BackColor = Color.FromArgb(35, 32, 39);
                btnCargosModificar.BackColor = Color.FromArgb(35, 32, 39);
                btnAreasModificar.BackColor = Color.FromArgb(35, 32, 39);
            }
            else
            {
                b.BackColor = Color.FromArgb(235, 42, 83);
                btnAsistenciasRegistrar.BackColor = Color.FromArgb(35, 32, 39);
                btnAsistenciasModificar.BackColor = Color.FromArgb(35, 32, 39);
                btnAsistenciasInformeGral.BackColor = Color.FromArgb(35, 32, 39);
                btnAsistenciasInformeInd.BackColor = Color.FromArgb(35, 32, 39);
                btnUsuariosAñadir.BackColor = Color.FromArgb(35, 32, 39);
                btnUsuariosModificar.BackColor = Color.FromArgb(35, 32, 39);
                btnCargosAñadir.BackColor = Color.FromArgb(35, 32, 39);
                btnCargosModificar.BackColor = Color.FromArgb(35, 32, 39);
                btnAreasAñadir.BackColor = Color.FromArgb(35, 32, 39);
            }
        }

        private void btnAsistencias_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAsistenciasSubMenu);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            showSubMenu(panelUsuariosSubMenu);
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
           showSubMenu(panelCargosSubMenu);
        }

        private void btnAreas_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAreasSubMenu);
        }

        private void btnAsistenciasRegistrar_Click(object sender, EventArgs e)
        {
            openChildForm(new AsistenciasRegistrar());
            botonSeleccionado(btnAsistenciasRegistrar);
        }

        private void btnAsistencicasModificar_Click(object sender, EventArgs e)
        {
            openChildForm(new AsistenciasModificar());
            botonSeleccionado(btnAsistenciasModificar);
        }

        private void btnAsistenciasInformeGral_Click(object sender, EventArgs e)
        {
            openChildForm(new AsistenciasInformeGral());
            botonSeleccionado(btnAsistenciasInformeGral);
        }

        private void btnAsistenciasInformeInd_Click(object sender, EventArgs e)
        {
            openChildForm(new AsistenciasInformeInd());
            botonSeleccionado(btnAsistenciasInformeInd);
        }

        private void btnUsuariosAñadir_Click(object sender, EventArgs e)
        {
            openChildForm(new UsuariosAñadir());
            botonSeleccionado(btnUsuariosAñadir);
        }

        private void btnUsuariosModificar_Click(object sender, EventArgs e)
        {
            openChildForm(new UsuariosModificar());
            botonSeleccionado(btnUsuariosModificar);
        }

        private void btnCargosAñadir_Click(object sender, EventArgs e)
        {
            openChildForm(new CargosAñadir(usuario, admin));
            botonSeleccionado(btnCargosAñadir);
        }

        private void btnCargosModificar_Click(object sender, EventArgs e)
        {
            openChildForm(new CargosModificar(usuario, admin));
            botonSeleccionado(btnCargosModificar);
        }

        private void btnAreasAñadir_Click(object sender, EventArgs e)
        {
            openChildForm(new AreasAñadir());
            botonSeleccionado(btnAreasAñadir);
        }

        private void btnAreasModificar_Click(object sender, EventArgs e)
        {
            openChildForm(new AreasModificar());
            botonSeleccionado(btnAreasModificar);
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
