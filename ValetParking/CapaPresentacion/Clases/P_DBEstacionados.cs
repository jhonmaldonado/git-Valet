using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Clases
{
    public class P_DBEstacionados
    {
        private string _Llave;
        private string _Placa;
        private string _TicketNumber;
        private string _Zona;
        private string _ValetRecepcion;
        private int _VP_Id_CupoLlave;
        private int _VP_IdPersonal_Asignado;
        private int _VP_IdZona;
        public string Llave { get => _Llave; set => _Llave = value; }
        public string Placa { get => _Placa; set => _Placa = value; }
        public string TicketNumber { get => _TicketNumber; set => _TicketNumber = value; }
        public string Zona { get => _Zona; set => _Zona = value; }
        public string ValetRecepcion { get => _ValetRecepcion; set => _ValetRecepcion = value; }
        public int VP_Id_CupoLlave { get => _VP_Id_CupoLlave; set => _VP_Id_CupoLlave = value; }
        public int VP_IdPersonal_Asignado { get => _VP_IdPersonal_Asignado; set => _VP_IdPersonal_Asignado = value; }
        public int VP_IdZona { get => _VP_IdZona; set => _VP_IdZona = value; }
    }
}
