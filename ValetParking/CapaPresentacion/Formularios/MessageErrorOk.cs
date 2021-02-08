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
    public partial class MessageErrorOk : Form
    {
        //1 Error, 2 Ok, 3 Advertencia -- Tipos de mensajes
        String MensajeMostrar = "";
        Int16 tipomensaje = 0;
        public MessageErrorOk(string Mensaje, Int16 tipoMensaje)
        {
            InitializeComponent();
            MensajeMostrar = Mensaje;
            tipomensaje = tipoMensaje;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void Salir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void MessageAdv_Load(object sender, EventArgs e)
        {
            bunifuFormFadeTransition1.ShowAsyc(this);
            lMessage.Text = MensajeMostrar;
            if (tipomensaje == 1)
            {
                pError.Visible = true;
            }
            else if (tipomensaje == 2)
            {
                pOk.Visible = true;
            }
            else
            {
                pAdvertencia.Visible = true;
            }
        }
        private void TimerClose_Tick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
