using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class N_Parametros
    {
        D_Parametros objDato = new D_Parametros();
        public List<E_Parametros> ListandoParametros(bool Estado)
        {
            return objDato.ListarParametros(Estado);
        }
        public void InsertandoParametro(E_Parametros Parametro)
        {
            objDato.InsertarParametro(Parametro);
        }
        public void EditandoParametro(E_Parametros Parametro)
        {
            objDato.EditarParametro(Parametro);
        }
        public void EliminandoParametro(E_Parametros Parametro)
        {
            objDato.EliminarParametro(Parametro);
        }
    }
}
