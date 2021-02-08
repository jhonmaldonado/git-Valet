using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Ger
    {
        Int16 _GerNr;
        string _GerBez;
        public short GerNr { get => _GerNr; set => _GerNr = value; }
        public string GerBez { get => _GerBez; set => _GerBez = value; }
    }
}
