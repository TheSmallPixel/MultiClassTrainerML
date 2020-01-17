using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PtfRiservePremi
    {
        public decimal IdRiservaPremi { get; set; }
        public decimal KeyTitTitolo { get; set; }
        public decimal IdTitTitolo { get; set; }
        public decimal IdPolizza { get; set; }
        public decimal IdCompagnia { get; set; }
        public decimal IdPrGaranzia { get; set; }
        public decimal IdPrGarScomposizione { get; set; }
        public decimal AnnoCompetenza { get; set; }
        public decimal MeseCompetenza { get; set; }
        public decimal IdTitTipoTitolo { get; set; }
        public string CodTipoTitolo { get; set; }
        public string FlgCategoriaEmesso { get; set; }
        public string CodGaranzia { get; set; }
        public string FlgCatTariffa { get; set; }
        public string FlgRamoBilancio { get; set; }
        public string NPolizza { get; set; }
        public DateTime DtEffetto { get; set; }
        public DateTime DtCopertura { get; set; }
        public decimal IdAgenzia { get; set; }
        public string CodAgenzia { get; set; }
        public decimal IdPrProdotto { get; set; }
        public string CodProdotto { get; set; }
        public decimal IdPrRamo { get; set; }
        public string CodRamo { get; set; }
        public decimal IdValuta { get; set; }
        public string CodValuta { get; set; }
        public decimal IdAnagrafica { get; set; }
        public string Contraente { get; set; }
        public decimal ImpRisPreNetto { get; set; }
        public decimal ImpRisPreAccessori { get; set; }
        public decimal ImpRisPreGarAcquisto { get; set; }
        public decimal ImpRisPreAccAcquisto { get; set; }
        public string FlgTipoCoass { get; set; }
        public decimal? PctQuota { get; set; }
        public string CompagniaCoass { get; set; }
        public DateTime? DtProdotto { get; set; }
        public decimal? IdSubagenzia { get; set; }
        public string CodSubagenzia { get; set; }
        public string CodFrazionamento { get; set; }
        public decimal AnnoGenerazione { get; set; }
        public decimal AnnoGenerazioneXRiass { get; set; }
    }
}
