using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_Movimiento_PL
    {
        D_Movimiento_PL objDato = new D_Movimiento_PL();
        public List<E_Movimiento_PL> ListandoMovimientos_EntryExit(Int32 seconds)
        {
            return objDato.ListarMovimiento_PL_EntryExit(seconds);
        }
        public List<E_Movimiento_PL> ListandoMovimientos_Transaction(Int32 seconds)
        {
            return objDato.ListarMovimiento_PL_Transaction(seconds);
        }
        public List<E_Ger> ListandoDevices()
        {
            return objDato.ListarDevices();
        }
    }
}
