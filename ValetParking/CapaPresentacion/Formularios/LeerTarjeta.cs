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
    public partial class LeerTarjeta : Form
    {
        String MensajeMostrar = "";
        public String Tarjeta = "";        
        List<string> TarjetasenUso;
        bool asignarnuevacard; //Indica si se está asignando tarjeta nueva a empleado.
        public LeerTarjeta(string Mensaje, List<string> TarjetasActivas, bool Asignando)
        {
            InitializeComponent();
            MensajeMostrar = Mensaje;
            TarjetasenUso = TarjetasActivas;
            asignarnuevacard = Asignando;
        }
        private void LeerTarjeta_Load(object sender, EventArgs e)
        {            
            bunifuFormFadeTransition1.ShowAsyc(this);
            lMessage.Text = MensajeMostrar;
            this.Focus();
        }
        private void Salir_Click(object sender, EventArgs e)
        {
            Tarjeta = "";
            this.Close();
        }
        private void LeerTarjeta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (asignarnuevacard)
                {
                    if (TarjetasenUso.Contains(Tarjeta))
                    {
                        ltjuso.Visible = true;
                        Tarjeta = "";
                    }
                    else
                    {
                        ltjuso.Visible = false;
                        //cierra el formulario            
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    if (TarjetasenUso.Contains(Tarjeta))
                    {
                        ltjuso.Visible = false;
                        //cierra el formulario            
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        ltjuso.Text = "Tarjeta inválida.";
                        ltjuso.Visible = true;
                        Tarjeta = "";
                    }
                }
            }
            else
            {
                Tarjeta += e.KeyCode.ToString().Last().ToString();
            }             
        }
        private void bunifuFlatButton_GestionControl_Click(object sender, EventArgs e)
        {
            Tarjeta = "";
            this.Close();
        }
        private void TimerClose_Tick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
