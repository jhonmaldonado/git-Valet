using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Parametros
    {
        private int _VP_IdParametro;
        private string _VP_TipoParametro;
        private bool _VP_Estado;
        private string _VP_Parametro1;
        private string _VP_Parametro2;
        private string _VP_Parametro3;

        public int VP_IdParametro { get => _VP_IdParametro; set => _VP_IdParametro = value; }
        public string VP_TipoParametro { get => _VP_TipoParametro; set => _VP_TipoParametro = value; }
        public bool VP_Estado { get => _VP_Estado; set => _VP_Estado = value; }
        public string VP_Parametro1 { get => _VP_Parametro1; set => _VP_Parametro1 = value; }
        public string VP_Parametro2 { get => _VP_Parametro2; set => _VP_Parametro2 = value; }
        public string VP_Parametro3 { get => _VP_Parametro3; set => _VP_Parametro3 = value; }
    }
}
