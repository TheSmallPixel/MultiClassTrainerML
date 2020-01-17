using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CtbSpese
    {
        public decimal KeySpesa { get; set; }
        public decimal IdSpesa { get; set; }
        public decimal? IdSpesaStornata { get; set; }
        public decimal? IdParcella { get; set; }
        public int? IdBeneficiariopagamento { get; set; }
        public DateTime DtOrdineSpesa { get; set; }
        public DateTime? DtPagamento { get; set; }
        public decimal ImpSpesa { get; set; }
        public decimal IdValuta { get; set; }
        public decimal? MeseInvioCoass { get; set; }
        public decimal? AnnoInvioCoass { get; set; }
        public decimal? ImpRitenuta { get; set; }
        public decimal? ImpCpa { get; set; }
        public decimal? ImpIva { get; set; }
        public decimal? ImpImponibile { get; set; }
        public string NAssegno { get; set; }
        public decimal? IdContocorrente { get; set; }
        public decimal? IdUtente { get; set; }
        public string FlgMezzoPagamento { get; set; }
        public string FlgMotivoStorno { get; set; }
        public string FlgStatoContabile { get; set; }
        public string FlgTipoCaricamento { get; set; }
        public string FlgTipoSpesa { get; set; }
        public decimal? AnnoInvioCid { get; set; }
        public decimal? MeseInvioCid { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdEntitacoinvolta { get; set; }
        public decimal? IdIncarico { get; set; }
        public decimal? IdEcdelegaaltrui { get; set; }
        public decimal IdSinistro { get; set; }
        public decimal? IdRecupero { get; set; }
        public string Note { get; set; }
        public decimal? IdContocorrenteComp { get; set; }
        public decimal? IdIspettorato { get; set; }
        public DateTime? DtScaricoContabile { get; set; }
        public string FlgSpesaSpotSino { get; set; }
        public decimal? ImpInps { get; set; }
        public decimal? ImpNonImponibile { get; set; }
        public string FlgNotaCreditoSino { get; set; }
        public string RifEsterno { get; set; }
        public string FlgStatoFatturaEstero { get; set; }
        public string FlgTipologiaGestione { get; set; }
        public string FlgRecordAnnullatoSino { get; set; }
        public string FlgRegulationQuotaSino { get; set; }
        public int? IdDanno { get; set; }
    }
}
