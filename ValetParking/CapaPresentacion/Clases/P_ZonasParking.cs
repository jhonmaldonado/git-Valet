using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Clases
{
    public class P_ZonasParking
    {
        private int _VP_Id_ZonaParking;
        private string _Nombre;
        private Int32 _Cupos;

        public int VP_Id_ZonaParking { get => _VP_Id_ZonaParking; set => _VP_Id_ZonaParking = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public Int32 Cupos { get => _Cupos; set => _Cupos = value; }
    }
}
