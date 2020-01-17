using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcSinistriAntiFrode
    {
        public int KeySinistroAntiFrode { get; set; }
        public int IdSinistroAntiFrode { get; set; }
        public int IdSinistro { get; set; }
        public int LivelloAntiFrode { get; set; }
        public string Note { get; set; }
        public DateTime DtEffetto { get; set; }
        public DateTime DtScadenza { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
        public string LivelloCriticita { get; set; }
        public string FrodeAccertata { get; set; }
        public string DataAggiornamento { get; set; }
    }
}
