using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TitGaranzie
    {
        public decimal KeyTitGaranzia { get; set; }
        public decimal? IdTitGaranzia { get; set; }
        public decimal? IdTitTitolo { get; set; }
        public decimal? IdPrGarScomposizione { get; set; }
        public decimal? IdPrGaranzia { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal? ImpNetto { get; set; }
        public decimal? ImpAccessori { get; set; }
        public decimal? ImpTasse { get; set; }
        public decimal? ImpSsn { get; set; }
        public decimal? ImpAntiracket { get; set; }
        public decimal? PctTasse { get; set; }
        public decimal? PctAntiracket { get; set; }
        public decimal? PctSsn { get; set; }
        public decimal? PctFvs { get; set; }
        public string FlgRamoBilancio { get; set; }
        public string FlgCatTariffa { get; set; }
        public decimal? PctVariazionePremio { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public DateTime? DtProdotto { get; set; }
        public decimal? ImpDetraibile { get; set; }
        public DateTime? DtScadenzaGaranzia { get; set; }
        public decimal? ImpFranchigiaAgg { get; set; }
    }
}
