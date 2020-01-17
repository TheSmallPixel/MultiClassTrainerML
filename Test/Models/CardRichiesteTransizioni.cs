using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CardRichiesteTransizioni
    {
        public int KeyRichiestaTransizione { get; set; }
        public int IdRichiestaTransizione { get; set; }
        public int? IdFunzioneSinistro { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdTransizioneStatoCard { get; set; }
        public DateTime? DtRichiesta { get; set; }
        public string FlgStatoTransizioneCard { get; set; }
        public DateTime? DtStatoTransizione { get; set; }
        public string FlgRichiestaScaRSino { get; set; }
        public int? IdClassificazioneStatoCard { get; set; }
        public string Note { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
        public string FlgInvioAutomaticoSino { get; set; }
        public int? IdUtenteRichiesta { get; set; }
        public DateTime? DtInvio { get; set; }
        public int? KeyStato { get; set; }
    }
}
