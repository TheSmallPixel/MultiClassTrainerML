using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrLineeProdotto
    {
        public decimal KeyPrLineaProdotto { get; set; }
        public decimal? IdPrLineaProdotto { get; set; }
        public string CodLinea { get; set; }
        public decimal? IdDescLinea { get; set; }
        public string FlgLineaProdotto { get; set; }
        public string Immagine { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string DescLinea { get; set; }
    }
}
