using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CtbQuietanze
    {
        public decimal KeyQuietanza { get; set; }
        public decimal IdQuietanza { get; set; }
        public DateTime DtEmissioneQuietanza { get; set; }
        public DateTime? DtRichiestaAut { get; set; }
        public DateTime? DtAutorizzazione { get; set; }
        public decimal? ImpReCose { get; set; }
        public decimal? ImpPersone { get; set; }
        public decimal? ImpVeicoli { get; set; }
        public decimal? ImpMinAutorizzatoReCose { get; set; }
        public decimal? ImpMaxAutorizzatoReCose { get; set; }
        public decimal? ImpMinAutorizzatoPersone { get; set; }
        public decimal? ImpMaxAutorizzatoPersone { get; set; }
        public decimal? ImpMinAutorizzatoVeicoli { get; set; }
        public decimal? ImpMaxAutorizzatoVeicoli { get; set; }
        public decimal IdValuta { get; set; }
        public string FlgParzialeReCoseSino { get; set; }
        public string FlgParzialePersSino { get; set; }
        public string FlgParzialeVeicSino { get; set; }
        public string FlgSeparataSino { get; set; }
        public string FlgStatoQuietanza { get; set; }
        public string FlgTipoCaricamento { get; set; }
        public decimal IdEntitacoinvolta { get; set; }
        public decimal IdSinistro { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtRestituzione { get; set; }
        public decimal? ImpRiservaReCose { get; set; }
        public decimal? ImpRiservaPersone { get; set; }
        public decimal? ImpRiservaVeicoli { get; set; }
        public int? IdBeneficiariopagamento { get; set; }
        public string FlgTipoAnagBeneficiario { get; set; }
        public int? IdDeroga { get; set; }
        public string FlgTipoProposta { get; set; }
        public int? IdUtenteOrdine { get; set; }
        public int? IdUtentePagamento { get; set; }
        public int? KeySchedaDanno { get; set; }
        public string CodiceCig { get; set; }
        public string RifEsterno { get; set; }
        public string FlgRecordAnnullatoSino { get; set; }
    }
}
