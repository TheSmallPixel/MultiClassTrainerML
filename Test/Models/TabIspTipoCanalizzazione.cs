using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabIspTipoCanalizzazione
    {
        public int IdIspTipoCanalizzazione { get; set; }
        public int IdIspettorato { get; set; }
        public DateTime DtInizioValidita { get; set; }
        public DateTime DtFineValidita { get; set; }
        public string FlgTipoCanalizzazioneIsp { get; set; }
    }
}
