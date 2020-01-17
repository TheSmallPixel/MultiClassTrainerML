using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrCombinazioni
    {
        public decimal KeyPrCombinazione { get; set; }
        public decimal? IdPrCombinazione { get; set; }
        public decimal? IdPrBene { get; set; }
        public decimal IdUtente { get; set; }
        public string CodCombinazione { get; set; }
        public decimal? IdDescCombinazione { get; set; }
        public decimal? ImpNetto { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string DescCombinazione { get; set; }
    }
}
