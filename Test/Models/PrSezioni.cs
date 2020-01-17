using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrSezioni
    {
        public decimal KeyPrSezione { get; set; }
        public decimal? IdPrSezione { get; set; }
        public decimal? IdPrBene { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? Ordine { get; set; }
        public string CodSezione { get; set; }
        public string DescSezione { get; set; }
        public decimal? IdDescSezione { get; set; }
    }
}
