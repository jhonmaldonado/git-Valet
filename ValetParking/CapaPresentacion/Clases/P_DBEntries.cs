using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Clases
{
    public class P_DBEntries
    {
        private DateTime _Fecha;
        private string _Placa;
        private string _TicketNumber;
        private string _Dispositivo;
        private Int16 _DisositivoNr;
        private Byte _Carpark;
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public string Placa { get => _Placa; set => _Placa = value; }
        public string TicketNumber { get => _TicketNumber; set => _TicketNumber = value; }
        public string Dispositivo { get => _Dispositivo; set => _Dispositivo = value; }
        public Int16 DisositivoNr { get => _DisositivoNr; set => _DisositivoNr = value; }
        public Byte Carpark { get => _Carpark; set => _Carpark = value; }
    }
}
