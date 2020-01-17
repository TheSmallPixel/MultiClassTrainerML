using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcRegFinBroker
    {
        public int IdRegFinBroker { get; set; }
        public int IdRetevendita { get; set; }
        public DateTime? DtRegolazione { get; set; }
        public DateTime? DtIncassiA { get; set; }
        public decimal? TotPagatoPremi { get; set; }
        public decimal? TotPagatoProvv { get; set; }
        public int? IdMfDato { get; set; }
        public DateTime DtSysRegistrazione { get; set; }
        public int IdCompagnia { get; set; }
        public int IdUtente { get; set; }
    }
}
