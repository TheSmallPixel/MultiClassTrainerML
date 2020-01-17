using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinAltriDati
    {
        public decimal KeyAltriDati { get; set; }
        public decimal IdAltriDati { get; set; }
        public decimal IdSinistro { get; set; }
        public string RegionePolizza { get; set; }
        public string TerzeParti { get; set; }
        public string Riassicurazione { get; set; }
        public string Proposta { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? PerTan { get; set; }
        public decimal? NRatePagate { get; set; }
        public string FlgInibizStampaErediSino { get; set; }
        public string NPrestito { get; set; }
        public DateTime? DtStipulaPrestito { get; set; }
        public string FlgRecuperatoDaAgenteSino { get; set; }
        public string FlgDatiCompletiSino { get; set; }
        public string FlgDenunciaIntSino { get; set; }
        public DateTime? DtRichiestaDocumenti { get; set; }
        public DateTime? DtDocumentiCompleti { get; set; }
        public DateTime? DtPresaInCarico { get; set; }
        public string FlgDocumentazioneSino { get; set; }
        public DateTime? DtPervenimentoDocumentazione { get; set; }
        public DateTime? DtInvioLetteraFantasma { get; set; }
        public string FlgAltoValoreSino { get; set; }
        public DateTime? DtRichiestaDanniFittizia { get; set; }
        public int? PunteggioCompagnia { get; set; }
        public int? ScoreAia { get; set; }
        public string TipoNotificaAia { get; set; }
        public string FlgParereAreeSpecialiSino { get; set; }
        public DateTime? DtRichiestaProbatori { get; set; }
        public string FlgTipologiaRisarcimento { get; set; }
        public int? IdNetwork { get; set; }
        public string FlgCausaleScartoAia { get; set; }
    }
}
