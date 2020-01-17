using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CardStati
    {
        public int KeyCardStato { get; set; }
        public int IdCardStato { get; set; }
        public int? IdClassificazioneStatoCard { get; set; }
        public int? KeyStato { get; set; }
        public string FlgMittenteDestinataria { get; set; }
        public string FlgRuoloGestionaria { get; set; }
        public string FlgRuoloRichiesta { get; set; }
        public int? IdCompagniaMittente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
        public string Note { get; set; }
        public string FlgProcessoAutomaticoSino { get; set; }
    }
}
