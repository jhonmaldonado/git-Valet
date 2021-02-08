using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Clases
{
    public class P_DBExit
    {
        private int _VP_IdMovimiento;
        private TimeSpan _TiempoEntrega;
        private DateTime _Fecha;
        private string _Placa;
        private string _TicketNumber;        
        private string _Zona;
        private Int32 _IdZona;
        private Int32 _IdValetRecepcion;
        private Int32 _IdValetAsignado;
        private Int32 _IdValetEntrega;
        private string _ValetRecepcion; 
        private string _ValetAsignado;
        private string _ValetEntrega;
        private string _Dispositivo;
        private Int16 _DisositivoNr;
        private Byte _Carpark;
        private Int32 _IdCupoLlave;

        public int VP_IdMovimiento { get => _VP_IdMovimiento; set => _VP_IdMovimiento = value; }
        public TimeSpan TiempoEntrega { get => _TiempoEntrega; set => _TiempoEntrega = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public string Placa { get => _Placa; set => _Placa = value; }
        public string TicketNumber { get => _TicketNumber; set => _TicketNumber = value; }
        public string Zona { get => _Zona; set => _Zona = value; }
        public int IdZona { get => _IdZona; set => _IdZona = value; }
        public int IdValetRecepcion { get => _IdValetRecepcion; set => _IdValetRecepcion = value; }
        public int IdValetAsignado { get => _IdValetAsignado; set => _IdValetAsignado = value; }
        public int IdValetEntrega { get => _IdValetEntrega; set => _IdValetEntrega = value; }
        public string ValetRecepcion { get => _ValetRecepcion; set => _ValetRecepcion = value; }
        public string ValetAsignado { get => _ValetAsignado; set => _ValetAsignado = value; }
        public string ValetEntrega { get => _ValetEntrega; set => _ValetEntrega = value; }
        public string Dispositivo { get => _Dispositivo; set => _Dispositivo = value; }
        public short DisositivoNr { get => _DisositivoNr; set => _DisositivoNr = value; }
        public byte Carpark { get => _Carpark; set => _Carpark = value; }
        public int IdCupoLlave { get => _IdCupoLlave; set => _IdCupoLlave = value; }
    }
}
