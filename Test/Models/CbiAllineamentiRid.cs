using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CbiAllineamentiRid
    {
        public int IdAllineamento { get; set; }
        public int IdCompagnia { get; set; }
        public DateTime DtElaborazione { get; set; }
        public int? IdContocorrenteAccredito { get; set; }
        public int IdPolizza { get; set; }
        public string FlgUltimoStato { get; set; }
        public DateTime DtUltimoStato { get; set; }
        public string FlgMotivoDiniego { get; set; }
        public int? IdAnagraficaPagatore { get; set; }
        public int? IdContocorrenteAddebito { get; set; }
        public string NumPolizza { get; set; }
        public string CodAbi { get; set; }
    }
}
