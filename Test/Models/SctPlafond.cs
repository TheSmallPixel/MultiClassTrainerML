using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SctPlafond
    {
        public decimal KeySctPlafond { get; set; }
        public decimal? IdSctPlafond { get; set; }
        public decimal? IdCompagnia { get; set; }
        public decimal? IdRetevendita { get; set; }
        public decimal? IdPrRamo { get; set; }
        public decimal? IdPrProdotto { get; set; }
        public decimal? ImpPlafond { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgMomentoSconto { get; set; }
    }
}
