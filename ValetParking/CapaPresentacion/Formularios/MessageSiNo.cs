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
    public partial class MessageSiNo : Form
    {
        String MensajeMostrar = "";
        public MessageSiNo(string Mensaje)
        {
            InitializeComponent();
            MensajeMostrar = Mensaje;
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            //cierra el formulario            
            DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            //cierra el formulario            
            DialogResult = DialogResult.No;
            this.Close();
        }

        private void MessageSiNo_Load(object sender, EventArgs e)
        {
            bunifuFormFadeTransition1.ShowAsyc(this);
            lMessage.Text = MensajeMostrar;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();
        }

        private void TimerClose_Tick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
