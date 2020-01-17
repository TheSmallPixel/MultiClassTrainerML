using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaAllegati
    {
        public int KeyAllegatoReteVendita { get; set; }
        public int IdAllegatoReteVendita { get; set; }
        public int IdRetevendita { get; set; }
        public int IdEntita { get; set; }
        public string FlgTipoOggetto { get; set; }
        public int IdAllegato { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
