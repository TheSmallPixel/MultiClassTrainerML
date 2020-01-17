using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CtbIndennizzi
    {
        public decimal KeyIndennizzo { get; set; }
        public decimal IdIndennizzo { get; set; }
        public decimal? IdIndennizzoStornato { get; set; }
        public DateTime DtOrdinePagamento { get; set; }
        public DateTime? DtPagamento { get; set; }
        public decimal? ImpPagReCose { get; set; }
        public decimal? ImpPagPersone { get; set; }
        public decimal? ImpPagVeicoli { get; set; }
        public decimal IdBeneficiariopagamento { get; set; }
        public decimal IdValuta { get; set; }
        public decimal? MeseInvioCoass { get; set; }
        public decimal? AnnoInvioCoass { get; set; }
        public decimal? MeseInvioCid { get; set; }
        public decimal? AnnoInvioCid { get; set; }
        public string NAssegno { get; set; }
        public decimal? IdContocorrente { get; set; }
        public decimal? IdUtente { get; set; }
        public string FlgLegaleCtpSino { get; set; }
        public string FlgMezzoPagamento { get; set; }
        public string FlgMotivoStorno { get; set; }
        public string FlgParzialeReCoseSino { get; set; }
        public string FlgParzialePersSino { get; set; }
        public string FlgParzialeVeicSino { get; set; }
        public string FlgSeparatoSino { get; set; }
        public string FlgStatoContabile { get; set; }
        public string FlgTipoCaricamento { get; set; }
        public string FlgTipoPagamentoCard { get; set; }
        public decimal? IdQuietanza { get; set; }
        public decimal? ImpDiCuiMorali { get; set; }
        public decimal? ImpDiCuiSpese { get; set; }
        public decimal? ImpDiCuiPatrimoniali { get; set; }
        public decimal? ImpDiCuiOnorari { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal IdEntitacoinvolta { get; set; }
        public decimal? IdEcdelegaaltrui { get; set; }
        public decimal? IdQuietanzaTesta { get; set; }
        public decimal IdSinistro { get; set; }
        public decimal? IdContocorrenteComp { get; set; }
        public decimal? IdIspettorato { get; set; }
        public DateTime? DtScaricoContabile { get; set; }
        public string FlgEntePagatore { get; set; }
        public decimal? IdEntePagatore { get; set; }
        public decimal? IdMandato { get; set; }
        public decimal? IdIndirizzo { get; set; }
        public string FlgTipoAnagBeneficiario { get; set; }
        public string FlgFuoriStanzaSino { get; set; }
        public decimal? ImpRiservaReCose { get; set; }
        public decimal? ImpRiservaPersone { get; set; }
        public decimal? ImpRiservaVeicoli { get; set; }
        public string NoteDisposizione { get; set; }
        public int? IdDeroga { get; set; }
        public string FlgTipoProposta { get; set; }
        public string FlgAutorizzatoSino { get; set; }
        public int? IdUtenteOrdine { get; set; }
        public int? IdUtentePagamento { get; set; }
        public int? IdUtenteAutorizzatore { get; set; }
        public int? IdUtenteAutorizzatoreDer { get; set; }
        public int? KeySchedaDanno { get; set; }
        public string CodiceCig { get; set; }
        public string NFogliocassa { get; set; }
        public string FlgRivalsaInpsSino { get; set; }
        public string FlgTipoCtt { get; set; }
        public string RifEsterno { get; set; }
        public string FlgTipoLiquidazione { get; set; }
        public string FlgRichiediDatiBersaniSino { get; set; }
        public string FlgOnorariSeparatiSino { get; set; }
        public string FlgRisSpecificoSino { get; set; }
        public string FlgRiparCarrConvSino { get; set; }
        public string FlgLiqNettoPenaleSino { get; set; }
        public decimal? ImpPenaleApplicata { get; set; }
        public string FlgStatoFatturaEstero { get; set; }
        public string FlgRecordAnnullatoSino { get; set; }
        public DateTime? DtStanza { get; set; }
        public string FlgPagamentoDirettoSino { get; set; }
        public decimal? ImpCorrentezza { get; set; }
        public string NoteCorrentezza { get; set; }
    }
}
