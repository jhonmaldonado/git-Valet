using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Movimiento_PL
    {
        private DateTime _Fecha;
        private string _NumeroTiquete;
        private string _Placa;
        private Int16 _DeviceNumber;
        private string _DeviceName;
        private Byte _MovementType;
        private Byte _Carpark;

        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public string NumeroTiquete { get => _NumeroTiquete; set => _NumeroTiquete = value; }
        public string Placa { get => _Placa; set => _Placa = value; }
        public Int16 DeviceNumber { get => _DeviceNumber; set => _DeviceNumber = value; }
        public string DeviceName { get => _DeviceName; set => _DeviceName = value; }
        public Byte MovementType { get => _MovementType; set => _MovementType = value; }
        public Byte Carpark { get => _Carpark; set => _Carpark = value; }
    }
}
