using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinAllegati
    {
        public decimal KeySinAllegato { get; set; }
        public decimal IdSinAllegato { get; set; }
        public decimal IdEntita { get; set; }
        public decimal IdAllegato { get; set; }
        public string FlgTipoOggetto { get; set; }
        public decimal IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
