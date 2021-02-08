using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Personal
    {
        private int _VP_IdPersonal;
        private string _VP_Id;
        private int _VP_IdPerfil;
        private int _VP_IdStatus;
        private string _Nombres;
        private string _Apellidos;
        private string _Telefono;
        private string _CodigoTarjeta;
        private string _RH;
        private string _PersonaContacto;
        private string _Telefono_PersonaContacto;  

        public int VP_IdPersonal { get => _VP_IdPersonal; set => _VP_IdPersonal = value; }
        public string VP_Id { get => _VP_Id; set => _VP_Id = value; }
        public int VP_IdPerfil { get => _VP_IdPerfil; set => _VP_IdPerfil = value; }
        public int VP_IdStatus { get => _VP_IdStatus; set => _VP_IdStatus = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string CodigoTarjeta { get => _CodigoTarjeta; set => _CodigoTarjeta = value; }
        public string RH { get => _RH; set => _RH = value; }
        public string PersonaContacto { get => _PersonaContacto; set => _PersonaContacto = value; }
        public string Telefono_PersonaContacto { get => _Telefono_PersonaContacto; set => _Telefono_PersonaContacto = value; }       
    }
}
