using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Clases
{
    public class P_CuposKeys
    {
        private int _VP_Id_CupoLlave;
        private string _Cupo;

        public int VP_Id_CupoLlave { get => _VP_Id_CupoLlave; set => _VP_Id_CupoLlave = value; }
        public string Cupo { get => _Cupo; set => _Cupo = value; }
    }
}
