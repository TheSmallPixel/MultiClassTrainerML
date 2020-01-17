using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinPeriodoScaricoDef
    {
        public int KeySinPeriodoScaricoDef { get; set; }
        public int? IdCompagnia { get; set; }
        public DateTime? DtScarico { get; set; }
        public int? IdUtente { get; set; }
        public DateTime? DtSistema { get; set; }
    }
}
