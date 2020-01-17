using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinInterventiLegali
    {
        public int IdInterventoLegale { get; set; }
        public int? IdRegione { get; set; }
        public int? IdRetevendita { get; set; }
        public int? IdSinistro { get; set; }
        public DateTime? DtInterventoLegale { get; set; }
        public DateTime? DtRegistrazioneSinistro { get; set; }
        public DateTime? DtScarico { get; set; }
    }
}
