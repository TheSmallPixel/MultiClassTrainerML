using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrRecessiRiscatti
    {
        public decimal KeyPrRecessoRiscatto { get; set; }
        public decimal? IdPrRecessoRiscatto { get; set; }
        public decimal? IdPrProdotto { get; set; }
        public decimal? DaGg { get; set; }
        public decimal? DaMm { get; set; }
        public decimal? DaAa { get; set; }
        public decimal? AGg { get; set; }
        public decimal? AMm { get; set; }
        public decimal? AAa { get; set; }
        public string FlgRecessoSino { get; set; }
        public decimal? ImpDiritti { get; set; }
        public decimal? PercValoreQuota { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
