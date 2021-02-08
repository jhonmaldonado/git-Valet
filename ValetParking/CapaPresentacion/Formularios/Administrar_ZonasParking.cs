using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class Administrar_ZonasParking : Form
    {
        E_Parametros objEntidad_Parametros = new E_Parametros();
        N_Parametros objNegocio_Parametros = new N_Parametros();
        bool Editando = false;
        int VP_IdZona_Selected = 0;
        DataGridViewRow row;
        public Administrar_ZonasParking()
        {
            InitializeComponent();
        }
        public void mostrarZonasParqueo(bool Status)
        {
            //Registra parámetros activos en memoria.
            Clases.P_ListasStatus.RegistraParametros(Status);
            var ParkingZone = (from zonas in Clases.P_ListasStatus.Zonasparking
                               orderby zonas.Nombre
                               select new
                               {
                                   zonas.VP_Id_ZonaParking,
                                   zonas.Nombre,
                                   zonas.Cupos,
                                   Estado = Status ? "Activo" : "Desactivado"
                               });

            DGZonas.DataSource = ParkingZone.ToList();
            DGZonas.ClearSelection();
        }
        private void Administrar_ZonarParking_Load(object sender, EventArgs e)
        {
            //Carga CuposLlaves activos en Tabla
            mostrarZonasParqueo(true);
        }
        private void Limpiar()
        {
            txtNombre.Text = "";
            txtCantCupos.Text = "";
            SwitchEstado.Value = true;
            pDerecha.Visible = true;
            txtNombre.Focus();

            PropiedadesTextBox(txtNombre, false);
        }
        private bool CamposObligatorios()
        {
            bool status = true;
            if (String.IsNullOrEmpty(txtNombre.Text))
            {
                PropiedadesTextBox(txtNombre, true);
                status = false;
            }
            else
            {
                PropiedadesTextBox(txtNombre, false);
            }

            if (String.IsNullOrEmpty(txtCantCupos.Text))
            {
                PropiedadesTextBox(txtCantCupos, true);
                status = false;
            }
            else
            {
                PropiedadesTextBox(txtCantCupos, false);
            }
            return status;
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
            { }
        }
        private void DGZonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                row = DGZonas.Rows[e.RowIndex];
            }
            catch
            { }
        }
        private void pIzquierda_SizeChanged(object sender, EventArgs e)
        {
            if (pIzquierda.Width > 580)
            {
                lTituloIzquierda.Visible = true;
            }
            else
            {
                lTituloIzquierda.Visible = false;
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Editando = false;
            Limpiar();
            lTituloDerecha.Text = "NUEVA ZONA DE PARQUEO";
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Editando = true; //Indica que se editará registro.
                if (DGZonas.SelectedRows.Count > 0)
                {
                    lTituloDerecha.Text = "EDITAR CUPO";
                    VP_IdZona_Selected = Convert.ToInt32(row.Cells["VP_Id_ZonaParking"].Value);
                    txtNombre.Text = Convert.ToString(row.Cells["Nombre"].Value);
                    txtCantCupos.Text = Convert.ToString(row.Cells["Cupos"].Value);
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
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!CamposObligatorios())
            {
                MessageErrorOk MensajeError = new MessageErrorOk("Por favor ingrese todos los datos obligatorios.", 3);
                MensajeError.ShowDialog();
                return;
            }

            if (!Editando)
            {
                try
                {
                    objEntidad_Parametros.VP_Estado = SwitchEstado.Value;
                    objEntidad_Parametros.VP_TipoParametro = "ZPAR";
                    objEntidad_Parametros.VP_Parametro1 = txtNombre.Text;
                    objEntidad_Parametros.VP_Parametro2 = txtCantCupos.Text;
                    objEntidad_Parametros.VP_Parametro3 = "";

                    objNegocio_Parametros.InsertandoParametro(objEntidad_Parametros);

                    MessageErrorOk MensajeError = new MessageErrorOk("Se creó Zona de Parqueo con Éxito.", 2);
                    MensajeError.ShowDialog();
                    Limpiar(); //Limpia formulario                
                    mostrarZonasParqueo(true);

                    SwitchPersonal.Value = true;
                    txtNombre.Focus();
                }
                catch (Exception ex)
                {
                    MessageErrorOk MensajeError = new MessageErrorOk("Error al crear Zona de Parqueo. " + Environment.NewLine + ex, 1);
                    MensajeError.ShowDialog();
                }
            }
            else
            {
                try
                {
                    objEntidad_Parametros.VP_IdParametro = VP_IdZona_Selected;
                    objEntidad_Parametros.VP_Estado = SwitchEstado.Value;
                    objEntidad_Parametros.VP_TipoParametro = "ZPAR";
                    objEntidad_Parametros.VP_Parametro1 = txtNombre.Text;
                    objEntidad_Parametros.VP_Parametro2 = txtCantCupos.Text;
                    objEntidad_Parametros.VP_Parametro3 = "";

                    objNegocio_Parametros.EditandoParametro(objEntidad_Parametros);

                    MessageErrorOk MensajeError = new MessageErrorOk("Se actualizó Zona de Parqueo con Éxito.", 2);
                    MensajeError.ShowDialog();
                    Limpiar(); //Limpia formulario                
                    mostrarZonasParqueo(true);

                    SwitchPersonal.Value = true;
                    txtNombre.Focus();
                }
                catch (Exception ex)
                {
                    MessageErrorOk MensajeError = new MessageErrorOk("Error al actualizar Zona de Parqueo. " + Environment.NewLine + ex, 1);
                    MensajeError.ShowDialog();
                }
            }
        }
        private void txtCantCupos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) e.Handled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DGZonas.ClearSelection();
            timer1.Enabled = false;
        }
        private void SwitchPersonal_Click(object sender, EventArgs e)
        {
            if (SwitchPersonal.Value)
            {
                mostrarZonasParqueo(true);
            }
            else
            {
                mostrarZonasParqueo(false);
            }
        }
    }
}
