using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaSicOffline
    {
        public int IdAniaSicOffline { get; set; }
        public DateTime? DtRicezione { get; set; }
        public string ProtocolloSic { get; set; }
        public string CodImpMand { get; set; }
        public string FlgTipoTargaMand { get; set; }
        public string TargaMand { get; set; }
        public string CodImpDeb { get; set; }
        public string FlgTipoTargaDeb { get; set; }
        public string TargaDeb { get; set; }
        public DateTime? DataAvvenimento { get; set; }
        public DateTime? DataMaxRisposta { get; set; }
        public string FlgRispostaOffline { get; set; }
        public DateTime? DataUltimaRisposta { get; set; }
        public string FlussoRicevuto { get; set; }
        public string FlgStato { get; set; }
        public int KeyAniaSicOffline { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
        public string FlgAssicuratoSino { get; set; }
    }
}
