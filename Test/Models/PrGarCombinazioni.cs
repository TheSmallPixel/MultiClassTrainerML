using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrGarCombinazioni
    {
        public decimal KeyPrGarCombinazione { get; set; }
        public decimal? IdPrGarCombinazione { get; set; }
        public decimal? IdPrCombinazione { get; set; }
        public decimal? IdPrGaranzia { get; set; }
        public decimal? IdUtente { get; set; }
        public string FlgAccessoriSino { get; set; }
        public decimal? ImpNetto { get; set; }
        public decimal ImpFranchigia { get; set; }
        public decimal PctScoperto { get; set; }
        public decimal ImpMaxScoperto { get; set; }
        public decimal Tasso { get; set; }
        public decimal ImpCapitale1 { get; set; }
        public decimal ImpCapitale2 { get; set; }
        public decimal ImpMaxSinistro { get; set; }
        public decimal ImpMaxPersone { get; set; }
        public decimal ImpMaxCose { get; set; }
        public decimal ImpMaxInterruzione { get; set; }
        public decimal? PctScomposizione { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
