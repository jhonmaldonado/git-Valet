using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class MenuValet : Form
    {
        public MenuValet()
        {
            InitializeComponent();
        }
        public void AbrirFormEnPanel(object Formhijo)
        {
            Form fh = Formhijo as Form;
            if (this.PanelContenedor.Controls.Count > 0)
            {
                foreach (Form forms in PanelContenedor.Controls.OfType<Form>())
                {
                    if ((forms.Name.Equals(fh.Name.ToString())))
                    {

                    }
                    else
                    {
                        if (this.PanelContenedor.Controls.Count > 0)
                            this.PanelContenedor.Controls.RemoveAt(0);

                        fh.TopLevel = false;
                        fh.FormBorderStyle = FormBorderStyle.None;
                        fh.Dock = DockStyle.Fill;
                        this.PanelContenedor.Controls.Add(fh);
                        this.PanelContenedor.Tag = fh;
                        fh.Show();
                    }
                }
            }
            else
            {
                fh.TopLevel = false;
                fh.FormBorderStyle = FormBorderStyle.None;
                fh.Dock = DockStyle.Fill;
                this.PanelContenedor.Controls.Add(fh);
                this.PanelContenedor.Tag = fh;
                fh.Show();
            }
        }
        private void MenuSidebar_Click(object sender, EventArgs e)
        {
            if (PanelLateral.Width == 240)
            {                
                PanelLateral.Visible = false;
                PanelLateral.Width = 64;
                SidebarWrapper.Width = 84;
                LineaSidebar.Width = 60;
                AnimacionSidebar.Show(PanelLateral);
                toolTip_Etiquetas.SetToolTip(MenuSidebar, "Restaurar Menú");
            }
            else
            { 
                PanelLateral.Visible = false;
                PanelLateral.Width = 240;
                SidebarWrapper.Width = 260;
                LineaSidebar.Width = 222;
                AnimacionSidebarBack.Show(PanelLateral);
                toolTip_Etiquetas.SetToolTip(MenuSidebar, "Ocultar Menú");
            }
        }
        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }
        private void Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }        
        private void MenuValet_Load(object sender, EventArgs e)
        {       
            //Registra parámetros activos en memoria.
            Clases.P_ListasStatus.RegistraParametros(true);
        }
        
        #region "Botones"
        private void bunifuFlatButton_GestionControl_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Formularios.ValetParking());
        }
        private void bunifuFlatButton_AdministrarPersonal_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Formularios.Administrar_Personal());
        }
        private void bunifuFlatButton_ZonasParqueo_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Formularios.Administrar_ZonasParking());
        }
        private void bunifuFlatButton_CasilleroLLaves_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Formularios.Administrar_Casilleros());
        }
        #endregion
    }
}
