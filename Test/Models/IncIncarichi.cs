using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class IncIncarichi
    {
        public decimal KeyIncarico { get; set; }
        public decimal IdIncarico { get; set; }
        public decimal IdFiduciario { get; set; }
        public DateTime DtIncarico { get; set; }
        public DateTime? DtScarico { get; set; }
        public decimal? ImpDanno { get; set; }
        public decimal IdValuta { get; set; }
        public decimal ImpPreventivoSpesa { get; set; }
        public decimal? IdTipoincaricofiduciario { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdEntitacoinvolta { get; set; }
        public decimal IdSinistro { get; set; }
        public DateTime? DtScaricoContabile { get; set; }
        public DateTime? DtLimite { get; set; }
        public string FlgEsitoIncarico { get; set; }
        public string NoteIncarico { get; set; }
        public string NoteScarico { get; set; }
        public string FlgStatoIncaricoSin { get; set; }
        public string FlgCoerenzaDanno { get; set; }
        public decimal? ImpConcordato { get; set; }
        public int? IdFiduciarioAssegnato { get; set; }
        public string FlgDannoVeicoliSino { get; set; }
        public string FlgDannoReCoseSino { get; set; }
        public string FlgDannoPersoneSino { get; set; }
        public string IdentificativoEsterno { get; set; }
        public decimal? ImpSpeseMediche { get; set; }
        public DateTime? DtAssegnazionePerito { get; set; }
        public int? IdCitazione { get; set; }
        public int? IdCausa { get; set; }
        public int? IdAtp { get; set; }
        public string FlgPortaleSino { get; set; }
        public string FlgTipoLiquidazione { get; set; }
        public string FlgTipoCaricamento { get; set; }
        public string FlgDichiarazioneRespPerizia { get; set; }
        public DateTime? DtPrimoSopraluogo { get; set; }
        public DateTime? DtRientro { get; set; }
        public DateTime? DtDichiarazioneRespPerizia { get; set; }
        public DateTime? DtMailAffidamentoRintracci { get; set; }
    }
}
