using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabTransizioniStati
    {
        public int IdTransizioneStato { get; set; }
        public int? IdStatoAttuale { get; set; }
        public int? IdStatoDestinazione { get; set; }
        public string Descrizione { get; set; }
        public string CodOggetto { get; set; }
        public string CodStatoAttuale { get; set; }
        public string CodStatoDestinazione { get; set; }
        public string FlgDefaultSino { get; set; }
        public string FlgFrizzabileSino { get; set; }
        public string FlgCardNaturaleSino { get; set; }
        public int? IdStatoOperazione { get; set; }
        public string FlgUsaScadenzeSino { get; set; }
        public string FlgInvioMailNotificaSino { get; set; }
    }
}
