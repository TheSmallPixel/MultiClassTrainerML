using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrAbbattimentiSconti
    {
        public int KeyPrAbbattimento { get; set; }
        public int? IdPrAbbattimento { get; set; }
        public int? IdPrProdotto { get; set; }
        public int? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string DescAbbattimento { get; set; }
        public int? IdDescAbbattimento { get; set; }
        public string FlgNumeroSinistri { get; set; }
        public string FlgTipoAbbattimento { get; set; }
        public int? PctAbbattimento { get; set; }
    }
}
