using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaNegocio;
namespace CapaPresentacion.Clases
{
    public static class P_ListasStatus
    {
        static List<E_Parametros> parametros;
        static List<Clases.P_Status> statusActDeact;
        static List<Clases.P_Status> tipoMovimiento;
        static List<Clases.P_Status> tiposPerfiles;
        static List<Clases.P_CuposKeys> cuposllaves;
        static List<Clases.P_ZonasParking> zonasparking;
        static List<Clases.P_Status> statusMovimiento;
        public static List<E_Parametros> Parametros { get => parametros; set => parametros = value; }
        public static List<P_Status> StatusActDeact { get => statusActDeact; set => statusActDeact = value; }
        public static List<P_Status> TipoMovimiento { get => tipoMovimiento; set => tipoMovimiento = value; }
        public static List<P_Status> TiposPerfiles { get => tiposPerfiles; set => tiposPerfiles = value; }
        public static List<P_CuposKeys> Cuposllaves { get => cuposllaves; set => cuposllaves = value; }
        public static List<P_ZonasParking> Zonasparking { get => zonasparking; set => zonasparking = value; }
        public static List<P_Status> StatusMovimiento { get => statusMovimiento; set => statusMovimiento = value; }
        public static void RegistraParametros(bool Status)
        {
            N_Parametros objNegocio = new N_Parametros();
            Parametros = objNegocio.ListandoParametros(Status);

            //STATUS PERSONAL ACT/DEACT
            var ActDeact = from p in Parametros
                           where p.VP_TipoParametro == "STAD"
                           select new Clases.P_Status { IdStatus = p.VP_IdParametro, Status = p.VP_Parametro1 };
            StatusActDeact = ActDeact.ToList();

            //STATUS MOVIMIENTO PARQUEO
            var Movimiento = from p in Parametros
                             where p.VP_TipoParametro == "MOVI"
                             select new Clases.P_Status { IdStatus = p.VP_IdParametro, Status = p.VP_Parametro1 };
            TipoMovimiento = Movimiento.ToList();

            //TIPOS PERFILES
            var Perfiles = from p in Parametros
                           where p.VP_TipoParametro == "PERF"
                           select new Clases.P_Status { IdStatus = p.VP_IdParametro, Status = p.VP_Parametro1 };
            TiposPerfiles = Perfiles.ToList();

            //CUPOS LLAVES
            var CLllaves = from p in Parametros
                           where p.VP_TipoParametro == "CUPO"
                           select new Clases.P_CuposKeys { VP_Id_CupoLlave = p.VP_IdParametro, Cupo = p.VP_Parametro1 };
            Cuposllaves = CLllaves.ToList();

            //CUPOS PARKING
            var ZonasP = from p in Parametros
                         where p.VP_TipoParametro == "ZPAR"
                         select new Clases.P_ZonasParking { VP_Id_ZonaParking = p.VP_IdParametro, Nombre = p.VP_Parametro1, Cupos = ParseNote(p.VP_Parametro2) };
            Zonasparking = ZonasP.ToList();

            //CUPOS PARKING
            var StatusM = from p in Parametros
                         where p.VP_TipoParametro == "STVP"
                         select new Clases.P_Status { IdStatus = p.VP_IdParametro, Status = p.VP_Parametro1 }; 
            StatusMovimiento = StatusM.ToList();
        }
        public static int ParseNote(string note)
        {
            int num = 0;
            Int32.TryParse(note, out num);
            return num;
        }
        public static void LimpiarParametros()
        {
            Parametros.Clear();
            StatusActDeact.Clear();
            TipoMovimiento.Clear();
            TiposPerfiles.Clear();
            Cuposllaves.Clear();
            Zonasparking.Clear();

        }
    }
}
