using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinContoEstintivo
    {
        public int KeyContoEstintivo { get; set; }
        public int IdContoEstintivo { get; set; }
        public int IdSinistro { get; set; }
        public decimal? ImpMontanteLordo { get; set; }
        public int? DurataAnni { get; set; }
        public int? NumRate { get; set; }
        public decimal? ImpRata { get; set; }
        public decimal? PctTan { get; set; }
        public decimal? TassoMensile { get; set; }
        public decimal? ImpCapitaleAssicurato { get; set; }
        public int? NumRatePagate { get; set; }
        public int? NumRateInsolute { get; set; }
        public int? NumRateScaduteInsolute { get; set; }
        public decimal? ImpDebitoResiduo { get; set; }
        public decimal? ImpTfrAmministrazione { get; set; }
        public decimal? ImpTfrFondo { get; set; }
        public decimal? ImpTfrVersato { get; set; }
        public decimal? ImpAltriIncassi { get; set; }
        public decimal? ImpQuoteRiconosciute { get; set; }
        public decimal? ImpRimbCommissioni { get; set; }
        public decimal? ImpTotDebitoResiduo { get; set; }
        public decimal? PctScoperto { get; set; }
        public decimal? ImpTotNettoScoperto { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
        public decimal? ImpTotNettoScopertoCon { get; set; }
        public decimal? ImpCorrettivo { get; set; }
        public string Note { get; set; }
    }
}
