using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class N_Personal
    {
        D_Personal objDato = new D_Personal();
        public List<E_Personal>ListandoPersonal(int Status)
        {
            return objDato.ListarPersonal(Status);
        }
        public void InsertandoPersonal(E_Personal Personal)
        {
            objDato.InsertarPersonal(Personal);
        }
        public void EditandoPersonal(E_Personal Personal)
        {
            objDato.EditarPersonal(Personal);
        }
    }
}
