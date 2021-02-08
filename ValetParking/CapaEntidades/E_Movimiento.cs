using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Movimiento
    {
        private int _VP_IdMovimiento;
        private int _VP_IdTipo_Movimiento;
        private int _VP_Id_CupoLlave;
        private int _VP_IdPersonal_Asignado;
        private int _VP_IdPersonal_Servicio;
        private int _VP_IdZona;
        private int _VP_IdStatus;
        private DateTime _FechaInicioProceso;
        private DateTime _FechaFinProceso;
        private string _PlateNumber;
        private string _TicketNumber;
        private Int16 _Device;
        private byte _Carpark;

        public int VP_IdMovimiento { get => _VP_IdMovimiento; set => _VP_IdMovimiento = value; }
        public int VP_IdTipo_Movimiento { get => _VP_IdTipo_Movimiento; set => _VP_IdTipo_Movimiento = value; }
        public int VP_Id_CupoLlave { get => _VP_Id_CupoLlave; set => _VP_Id_CupoLlave = value; }
        public int VP_IdPersonal_Asignado { get => _VP_IdPersonal_Asignado; set => _VP_IdPersonal_Asignado = value; }
        public int VP_IdPersonal_Servicio { get => _VP_IdPersonal_Servicio; set => _VP_IdPersonal_Servicio = value; }
        public int VP_IdZona { get => _VP_IdZona; set => _VP_IdZona = value; }
        public int VP_IdStatus { get => _VP_IdStatus; set => _VP_IdStatus = value; }
        public DateTime FechaInicioProceso { get => _FechaInicioProceso; set => _FechaInicioProceso = value; }
        public DateTime FechaFinProceso { get => _FechaFinProceso; set => _FechaFinProceso = value; }
        public string PlateNumber { get => _PlateNumber; set => _PlateNumber = value; }
        public string TicketNumber { get => _TicketNumber; set => _TicketNumber = value; }
        public Int16 Device { get => _Device; set => _Device = value; }
        public byte Carpark { get => _Carpark; set => _Carpark = value; }
    }
}
