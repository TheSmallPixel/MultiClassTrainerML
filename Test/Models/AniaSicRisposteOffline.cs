using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaSicRisposteOffline
    {
        public int IdAniaSicRispostaOffline { get; set; }
        public int IdAniaSicOffline { get; set; }
        public DateTime? DtInvio { get; set; }
        public string FlgRispostaOffline { get; set; }
        public string CodErrore { get; set; }
        public string TipoErrore { get; set; }
        public string FlussoInviato { get; set; }
        public string FlussoRicevuto { get; set; }
        public int KeyAniaSicRispostaOffline { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
    }
}
