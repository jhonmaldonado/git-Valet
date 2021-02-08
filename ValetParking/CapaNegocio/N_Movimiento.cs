using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class N_Movimiento        
    {
        D_Movimiento objDato = new D_Movimiento();
        public List<E_Movimiento> ListandoMovimientos()
        {
            return objDato.ListarMovimiento();
        }
        public void InsertandoMovimiento(E_Movimiento Movimiento)
        {            
            objDato.InsertarMovimiento(Movimiento);
        }
        public void EditandoMovimiento(E_Movimiento Movimiento)
        {
            objDato.EditarMovimiento(Movimiento);
        }
        public void EliminandoMovimiento(E_Movimiento Movimiento)
        {
            objDato.EliminarMovimiento(Movimiento);
        }
    }
}
