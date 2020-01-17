using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabCalendarioStanzaAnia
    {
        public int IdTabCalendarioStanzaAnia { get; set; }
        public string AnnoMeseStanza { get; set; }
        public DateTime? DtAperturaStanza { get; set; }
        public DateTime? DtChiusuraStanza { get; set; }
        public DateTime? DtElaborazioneStanza { get; set; }
        public DateTime? DtRegolazioneSaldiDebito { get; set; }
        public DateTime? DtRegolazioneSaldiCredito { get; set; }
        public string FlgTrimestraleSino { get; set; }
    }
}
