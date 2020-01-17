using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class IncParcelle
    {
        public decimal KeyParcella { get; set; }
        public decimal IdParcella { get; set; }
        public DateTime? DtFattura { get; set; }
        public string NFattura { get; set; }
        public string FlgProformaSino { get; set; }
        public decimal? IdFiduciario { get; set; }
        public decimal? IdStudiofiduciario { get; set; }
        public DateTime? DtStato { get; set; }
        public string NAssegno { get; set; }
        public decimal? IdContocorrente { get; set; }
        public decimal IdValuta { get; set; }
        public decimal? IdUtente { get; set; }
        public string FlgStatoContabile { get; set; }
        public string FlgMezzoPagamento { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdContocorrenteComp { get; set; }
        public decimal? IdMandato { get; set; }
        public string Note { get; set; }
        public decimal? ImpRitenuta { get; set; }
        public decimal? IdFiduciarioCorr { get; set; }
        public string FlgSpeseGestioneSino { get; set; }
        public string NProforma { get; set; }
        public DateTime? DtProforma { get; set; }
        public string FlgTipoParcella { get; set; }
        public string FlgPersRitenutaSino { get; set; }
        public string FlgIntestatario { get; set; }
        public string FlgTipoCaricamento { get; set; }
        public string RifEsternoParcella { get; set; }
    }
}
