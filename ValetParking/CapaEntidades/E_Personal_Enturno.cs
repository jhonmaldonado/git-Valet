using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Personal_Enturno
    {
        private DateTime _Fecha;
        private int _VP_IdPersonal;
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public int VP_IdPersonal { get => _VP_IdPersonal; set => _VP_IdPersonal = value; }
    }
}
