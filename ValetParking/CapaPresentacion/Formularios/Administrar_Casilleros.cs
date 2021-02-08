using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class Administrar_Casilleros : Form
    {
        E_Parametros objEntidad_Parametros = new E_Parametros();
        N_Parametros objNegocio_Parametros = new N_Parametros();
        bool Editando = false;
        int VP_IdCupo_Selected = 0;
        DataGridViewRow row;
        public Administrar_Casilleros()
        {
            InitializeComponent();
        }
        public void mostrarCuposLlaves(bool Status)
        {
            //Registra parámetros activos en memoria.
            Clases.P_ListasStatus.RegistraParametros(Status);
            var cupos = (from cups in Clases.P_ListasStatus.Cuposllaves
                         orderby cups.Cupo
                         select new
                         {
                             cups.VP_Id_CupoLlave,
                             cups.Cupo,
                             Estado = Status ? "Activo" : "Desactivado"
                         });

            DGCuposLlaves.DataSource = cupos.ToList();
            DGCuposLlaves.ClearSelection();
        }
        private void Administrar_Casilleros_Load(object sender, EventArgs e)
        {
            //Carga CuposLlaves activos en Tabla
            mostrarCuposLlaves(true);
        }
        private void Limpiar()
        {
            txtNombre.Text = "";
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
                    objEntidad_Parametros.VP_TipoParametro = "CUPO";
                    objEntidad_Parametros.VP_Parametro1 = txtNombre.Text;
                    objEntidad_Parametros.VP_Parametro2 = "";
                    objEntidad_Parametros.VP_Parametro3 = "";

                    objNegocio_Parametros.InsertandoParametro(objEntidad_Parametros);

                    MessageErrorOk MensajeError = new MessageErrorOk("Se creó cupo de llave con Éxito.", 2);
                    MensajeError.ShowDialog();
                    Limpiar(); //Limpia formulario                
                    mostrarCuposLlaves(true);

                    SwitchPersonal.Value = true;
                    txtNombre.Focus();                    
                }
                catch (Exception ex)
                {
                    MessageErrorOk MensajeError = new MessageErrorOk("Error al crear cupo de llave. " + Environment.NewLine + ex, 1);
                    MensajeError.ShowDialog();
                }
            }
            else
            {
                try
                {
                    objEntidad_Parametros.VP_IdParametro = VP_IdCupo_Selected;
                    objEntidad_Parametros.VP_Estado = SwitchEstado.Value;
                    objEntidad_Parametros.VP_TipoParametro = "CUPO";
                    objEntidad_Parametros.VP_Parametro1 = txtNombre.Text;
                    objEntidad_Parametros.VP_Parametro2 = "";
                    objEntidad_Parametros.VP_Parametro3 = "";

                    objNegocio_Parametros.EditandoParametro(objEntidad_Parametros);

                    MessageErrorOk MensajeError = new MessageErrorOk("Se actualizó cupo de llave con Éxito.", 2);
                    MensajeError.ShowDialog();
                    Limpiar(); //Limpia formulario                
                    mostrarCuposLlaves(true);

                    SwitchPersonal.Value = true;
                    txtNombre.Focus();                    
                }
                catch (Exception ex)
                {
                    MessageErrorOk MensajeError = new MessageErrorOk("Error al actualizar cupo de llave. " + Environment.NewLine + ex, 1);
                    MensajeError.ShowDialog();
                }
            }

        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Editando = true; //Indica que se editará registro.
                if (DGCuposLlaves.SelectedRows.Count > 0)
                {
                    lTituloDerecha.Text = "EDITAR CUPO";
                    VP_IdCupo_Selected = Convert.ToInt32(row.Cells["VP_Id_CupoLlave"].Value);
                    txtNombre.Text = Convert.ToString(row.Cells["Cupo"].Value);
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
        private void DGCuposLlaves_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                row = DGCuposLlaves.Rows[e.RowIndex];
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
            lTituloDerecha.Text = "NUEVO CUPO LLAVE";
        }
        private void SwitchPersonal_Click(object sender, EventArgs e)
        {
            if (SwitchPersonal.Value)
            {
                mostrarCuposLlaves(true);
            }
            else
            {
                mostrarCuposLlaves(false);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DGCuposLlaves.ClearSelection();
            timer1.Enabled = false;
        }
       
        private void txtNombre_Enter(object sender, EventArgs e)
        {
           
        }
    }
}
