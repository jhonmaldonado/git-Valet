using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades;

namespace CapaPresentacion.Formularios
{
    public partial class Administrar_Personal : Form
    {        
        int VP_IdPersonal_Selected = 0;
        DataGridViewRow row;
        bool Editarse = false;

        public List<String> TarjetasActivas;
        E_Personal objEntidad_Personal = new E_Personal();
        N_Personal objNegocio_Personal = new N_Personal();

        public Administrar_Personal()
        {
            InitializeComponent();
        }
        public void tarjetasactivas(int Status)
        {            
            N_Personal objPersonal = new N_Personal();
            TarjetasActivas = (from pers in objPersonal.ListandoPersonal(Status)                            
                            select                                
                            pers.CodigoTarjeta
                            ).ToList();
        }
        public void mostrarEmpleados(int Status)
        {
            N_Personal objPersonal = new N_Personal();
            var perfiles = (from pers in objPersonal.ListandoPersonal(Status)
                            join perf in Clases.P_ListasStatus.TiposPerfiles on pers.VP_IdPerfil equals perf.IdStatus  
                            join stat in Clases.P_ListasStatus.StatusActDeact on pers.VP_IdStatus equals stat.IdStatus
                            select new
                            {
                                pers.VP_IdPersonal,
                                pers.VP_Id,
                                perfil = perf.Status,
                                pers.VP_IdStatus,
                                status = stat.Status,
                                pers.Nombres,
                                pers.Apellidos,
                                pers.Telefono,
                                pers.CodigoTarjeta,
                                pers.RH,
                                pers.PersonaContacto,
                                pers.Telefono_PersonaContacto
                            });
            
            DGPersonal.DataSource = perfiles.ToList();
            DGPersonal.ClearSelection();
        }        
        private void FiltrarStatus(string TextoStatus)
        {            
            int Status = (from status in Clases.P_ListasStatus.StatusActDeact.AsEnumerable()
                          where status.Status == TextoStatus
                          select status.IdStatus).FirstOrDefault();
            
            mostrarEmpleados(Status);            
            tarjetasactivas(Status);                     
        }
        private void Administrar_Personal_Load(object sender, EventArgs e)
        {
            FiltrarStatus("Activo");            
        }
        private void SwitchPersonal_Click(object sender, EventArgs e)
        {
            if (SwitchPersonal.Value)
            {
                FiltrarStatus("Activo");
            }
            else
            {
                FiltrarStatus("Desactivado");
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            lTituloDerecha.Text = "NUEVO VALET PARKING";
        }
        private void Limpiar()
        {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtTelefono.Text = "";
            txtRH.Text = "";
            txtPersonaContacto.Text = "";
            txtTelefono_PersonaContacto.Text = "";
            lbCodigoTarjeta.Text = "";          
            btnCodigoTarjeta.Text = "ASIGNAR TARJETA";
            SwitchEstado.Value = true;            
            pDerecha.Visible = true;
            txtNombres.Focus();

            PropiedadesTextBox(txtNombres, false);
            PropiedadesTextBox(txtApellidos, false);
            PropiedadesTextBox(txtTelefono, false);
            PropiedadesTextBox(txtRH, false);
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Editarse = true; //Indica que se editará registro.
                if (DGPersonal.SelectedRows.Count > 0)
                {
                    string[] Nombre1 = Convert.ToString(row.Cells["Nombres"].Value).ToUpper().Split(' ');
                    string[] Apellido1 = Convert.ToString(row.Cells["Apellidos"].Value).ToUpper().Split(' ');
                    lTituloDerecha.Text = "EDITAR VALET - " + (Nombre1.Length > 0 ? Nombre1[0] : "") + " " + (Apellido1.Length > 0 ? Apellido1[0] : "");
                    VP_IdPersonal_Selected = Convert.ToInt32(row.Cells["VP_IdPersonal"].Value);
                    txtNombres.Text = Convert.ToString(row.Cells["Nombres"].Value);
                    txtApellidos.Text = Convert.ToString(row.Cells["Apellidos"].Value);
                    txtTelefono.Text = Convert.ToString(row.Cells["Telefono"].Value);
                    txtRH.Text = Convert.ToString(row.Cells["RH"].Value);
                    txtPersonaContacto.Text = Convert.ToString(row.Cells["PersonaContacto"].Value);
                    txtTelefono_PersonaContacto.Text = Convert.ToString(row.Cells["Telefono_PersonaContacto"].Value);
                    lbCodigoTarjeta.Text = Convert.ToString(row.Cells["CodigoTarjeta"].Value);
                    btnCodigoTarjeta.Text = "MODIFICAR TARJETA";
                    if (Convert.ToString(row.Cells["Estado"].Value) == "Activo")
                    {
                        SwitchEstado.Value = true;
                    }
                    else
                    {
                        SwitchEstado.Value = false;
                    }
                }
                else
                {
                    MessageErrorOk Message = new MessageErrorOk("Por favor seleccione un registro para editar.", 3);
                    Message.ShowDialog();
                }
            }
            catch { }            
        }
        private void DGPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                row = DGPersonal.Rows[e.RowIndex];
            }
            catch
            {}           
        }
        private void PropiedadesTextBox(Bunifu.Framework.UI.BunifuMetroTextbox Element, bool Alert)
        {
            try
            {
                Color BackNormal = SystemColors.Control;
                Color BackAlerta = Color.FromArgb(253, 238, 135);
                Color BorderNormal = Color.FromArgb(211, 162, 25);
                Color BorderAlerta = Color.FromArgb(91, 91, 91);

                if (Alert)
                {
                    Element.BackColor = BackAlerta;
                    Element.BorderColorFocused = BorderAlerta;
                    Element.BorderColorMouseHover = BorderAlerta;
                }
                else
                {
                    Element.BackColor = BackNormal;
                    Element.BorderColorFocused = BorderNormal;
                    Element.BorderColorMouseHover = BorderNormal;
                }
            }
            catch
            {}           
        }
        private bool CamposObligatorios()
        {
            bool status = true;
            if (String.IsNullOrEmpty(txtNombres.Text))
            {
                PropiedadesTextBox(txtNombres, true);
                status = false;
            }
            else
            {
                PropiedadesTextBox(txtNombres, false);
            }

            if (String.IsNullOrEmpty(txtApellidos.Text))
            {
                PropiedadesTextBox(txtApellidos, true);
                status = false;
            }
            else
            {
                PropiedadesTextBox(txtApellidos, false);
            }

            if (String.IsNullOrEmpty(txtTelefono.Text))
            {
                PropiedadesTextBox(txtTelefono, true);
                status = false;
            }
            else
            {
                PropiedadesTextBox(txtTelefono, false);
            }

            if (String.IsNullOrEmpty(txtRH.Text))
            {
                PropiedadesTextBox(txtRH, true);
                status = false;
            }
            else
            {
                PropiedadesTextBox(txtRH, false);
            }

            if (String.IsNullOrEmpty(lbCodigoTarjeta.Text))
            {
                LeerTarjeta LeerTarjeta = new LeerTarjeta("Por favor acerque una tarjeta al lector.", TarjetasActivas, true);
                if (LeerTarjeta.ShowDialog() == DialogResult.OK)
                {
                    lbCodigoTarjeta.Text = LeerTarjeta.Tarjeta; //lee la propiedad
                }
                else
                {
                    status = false;
                }
            }            
            return status;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!CamposObligatorios())
            {
                MessageErrorOk MensajeError = new MessageErrorOk("Por favor ingrese todos los datos obligatorios.", 3);
                MensajeError.ShowDialog();                
                return;
            }
            string filtroEstado = "";
            if (SwitchEstado.Value)
            {
                filtroEstado = "Activo";
            }
            else
            {
                filtroEstado = "Desactivado";
            }

            var varIdStatus = (from perf in Clases.P_ListasStatus.StatusActDeact
                              where perf.Status == filtroEstado
                              select new { perf.IdStatus }).FirstOrDefault();

            var varIdPerfil = (from perf in Clases.P_ListasStatus.TiposPerfiles
                           where perf.Status == "Valet"
                           select new { perf.IdStatus }).FirstOrDefault();

            if (Editarse == false && varIdPerfil.IdStatus != 0 && varIdStatus.IdStatus != 0)
            {
                try
                {
                    objEntidad_Personal.VP_IdPerfil = varIdPerfil.IdStatus;
                    objEntidad_Personal.VP_IdStatus = varIdStatus.IdStatus;
                    objEntidad_Personal.Nombres = txtNombres.Text;
                    objEntidad_Personal.Apellidos = txtApellidos.Text;
                    objEntidad_Personal.Telefono = txtTelefono.Text;
                    objEntidad_Personal.CodigoTarjeta = lbCodigoTarjeta.Text;
                    objEntidad_Personal.RH = txtRH.Text;
                    objEntidad_Personal.PersonaContacto = txtPersonaContacto.Text;
                    objEntidad_Personal.Telefono_PersonaContacto = txtTelefono_PersonaContacto.Text;

                    objNegocio_Personal.InsertandoPersonal(objEntidad_Personal);

                    MessageErrorOk MensajeError = new MessageErrorOk("Se creó empleado con Éxito.", 2);
                    MensajeError.ShowDialog();                    
                    Limpiar(); //Limpia formulario
                    FiltrarStatus("Activo"); //Actualiza tabla empleados
                }
                catch(Exception ex)
                {
                    MessageErrorOk MensajeError = new MessageErrorOk("Error al crear empleado. " + Environment.NewLine + ex, 1);
                    MensajeError.ShowDialog();                    
                }
            }
            else
            {
                try
                {
                    objEntidad_Personal.VP_IdPersonal = VP_IdPersonal_Selected;
                    objEntidad_Personal.VP_IdPerfil = varIdPerfil.IdStatus;
                    objEntidad_Personal.VP_IdStatus = varIdStatus.IdStatus;
                    objEntidad_Personal.Nombres = txtNombres.Text;
                    objEntidad_Personal.Apellidos = txtApellidos.Text;
                    objEntidad_Personal.Telefono = txtTelefono.Text;
                    objEntidad_Personal.CodigoTarjeta = lbCodigoTarjeta.Text;
                    objEntidad_Personal.RH = txtRH.Text;
                    objEntidad_Personal.PersonaContacto = txtPersonaContacto.Text;
                    objEntidad_Personal.Telefono_PersonaContacto = txtTelefono_PersonaContacto.Text;

                    objNegocio_Personal.EditandoPersonal(objEntidad_Personal);

                    MessageErrorOk MensajeError = new MessageErrorOk("Se modificó empleado con Éxito.", 2);
                    MensajeError.ShowDialog();
                    Limpiar(); //Limpia formulario
                    FiltrarStatus("Activo"); //Actualiza tabla empleados
                }
                catch (Exception ex)
                {
                    MessageErrorOk MensajeError = new MessageErrorOk("Error al editar empleado. " + Environment.NewLine + ex, 1);
                    MensajeError.ShowDialog();                    
                }
            }
            Editarse = false;
            SwitchPersonal.Value = true;
            SwitchEstado.Value = true;
        }
        private void btnCodigoTarjeta_Click(object sender, EventArgs e)
        {
            LeerTarjeta LeerTarjeta = new LeerTarjeta("Por favor acerque una tarjeta al lector.", TarjetasActivas, true);
            if (LeerTarjeta.ShowDialog() == DialogResult.OK)
            {
                lbCodigoTarjeta.Text = LeerTarjeta.Tarjeta;//lee la propiedad
            }                            
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DGPersonal.SelectedRows.Count > 0)
            {
                MessageSiNo Message = new MessageSiNo("Está seguro de eliminar al empleado: " + Environment.NewLine + Environment.NewLine + Convert.ToString(row.Cells["Nombres"].Value) + " " + Convert.ToString(row.Cells["Apellidos"].Value) + ".");
                if (Message.ShowDialog() == DialogResult.No)
                {
                    return;
                }

                var varIdStatus = (from perf in Clases.P_ListasStatus.StatusActDeact
                                   where perf.Status == "Eliminado"
                                   select new { perf.IdStatus }).FirstOrDefault();

                var varIdPerfil = (from perf in Clases.P_ListasStatus.TiposPerfiles
                                   where perf.Status == "Valet"
                                   select new { perf.IdStatus }).FirstOrDefault();

                if (varIdStatus.IdStatus != 0 && varIdPerfil.IdStatus != 0)
                {
                    try
                    {
                        objEntidad_Personal.VP_IdPersonal = Convert.ToInt32(row.Cells["VP_IdPersonal"].Value);
                        objEntidad_Personal.VP_IdPerfil = varIdPerfil.IdStatus;
                        objEntidad_Personal.VP_IdStatus = varIdStatus.IdStatus;
                        objEntidad_Personal.Nombres = Convert.ToString(row.Cells["Nombres"].Value);
                        objEntidad_Personal.Apellidos = Convert.ToString(row.Cells["Apellidos"].Value);
                        objEntidad_Personal.Telefono = Convert.ToString(row.Cells["Telefono"].Value);
                        objEntidad_Personal.CodigoTarjeta = "";
                        objEntidad_Personal.RH = Convert.ToString(row.Cells["RH"].Value);
                        objEntidad_Personal.PersonaContacto = Convert.ToString(row.Cells["PersonaContacto"].Value);
                        objEntidad_Personal.Telefono_PersonaContacto = Convert.ToString(row.Cells["Telefono_PersonaContacto"].Value);

                        objNegocio_Personal.EditandoPersonal(objEntidad_Personal);

                        MessageErrorOk MessageAdvertencia = new MessageErrorOk("Se eliminó empleado con Éxito.", 2);
                        MessageAdvertencia.ShowDialog();

                        Limpiar(); //Limpia formulario
                        FiltrarStatus("Activo"); //Actualiza tabla empleados
                    }
                    catch (Exception ex)
                    {
                        MessageErrorOk MessageAdvertencia = new MessageErrorOk("Error al eliminar empleado." + Environment.NewLine + ex, 1);
                        MessageAdvertencia.ShowDialog();                       
                    }
                }               
            }
            else
            {
                MessageErrorOk MensajeError = new MessageErrorOk("Por favor seleccione un registro para eliminar.", 3);
                MensajeError.ShowDialog();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DGPersonal.ClearSelection();
            timer1.Enabled = false;
        }
        private void pIzquierda_ClientSizeChanged(object sender, EventArgs e)
        {
            if (pIzquierda.Width > 700)
            {
                lTituloIzquierda.Visible = true;
            }
            else
            {
                lTituloIzquierda.Visible = false;
            }
        }
    }
}
