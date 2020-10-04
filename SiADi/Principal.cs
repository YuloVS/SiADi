using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiADi
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            hideSubMenu();
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
           
        }

        private void btnAsistencicasModificar_Click(object sender, EventArgs e)
        {
            openChildForm(new AsistenciasModificar());
        }

        private void btnAsistenciasInformeGral_Click(object sender, EventArgs e)
        {
            openChildForm(new AsistenciasInformeGral());
        }

        private void btnAsistenciasInformeInd_Click(object sender, EventArgs e)
        {
            openChildForm(new AsistenciasInformeInd());
        }

        private void btnUsuariosAñadir_Click(object sender, EventArgs e)
        {
            openChildForm(new UsuariosAñadir());
        }

        private void btnUsuariosModificar_Click(object sender, EventArgs e)
        {
            openChildForm(new UsuariosModificar());
        }

        private void btnCargosAñadir_Click(object sender, EventArgs e)
        {
            openChildForm(new CargosAñadir());
        }

        private void btnCargosModificar_Click(object sender, EventArgs e)
        {
            openChildForm(new CargosModificar());
        }

        private void btnAreasAñadir_Click(object sender, EventArgs e)
        {
            openChildForm(new AreasAñadir());
        }

        private void btnAreasModificar_Click(object sender, EventArgs e)
        {
            openChildForm(new AreasModificar());
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
