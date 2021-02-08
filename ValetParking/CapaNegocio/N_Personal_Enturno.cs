using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class N_Personal_Enturno
    {
        D_Personal_Enturno objDato = new D_Personal_Enturno();
        public List<E_Personal_Enturno> ListandoPersonal_Enturno()
        {
            return objDato.ListarPersonal_Enturno();
        }
        public void InsertandoPersonal_Enturno(E_Personal_Enturno Personal_Enturno)
        {
            objDato.InsertarPersonal_Enturno(Personal_Enturno);
        }
        public void ActualizandoPersonal_Enturno(E_Personal_Enturno Personal_Enturno)
        {
            objDato.ActualizarPersonal_Enturno(Personal_Enturno);
        }
        public void EliminandoPersonal_Enturno(E_Personal_Enturno Personal_Enturno)
        {
            objDato.EliminarPersonal_Enturno(Personal_Enturno);
        }
    }
}
