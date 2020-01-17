using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CardAllegatiTransizioni
    {
        public int KeyCardAllegatoTransizione { get; set; }
        public int IdCardAllegatoTransizione { get; set; }
        public int? IdRichiestaTransizione { get; set; }
        public int? KeyStato { get; set; }
        public int? IdAllegato { get; set; }
        public int? IdSinistro { get; set; }
        public string FlgTipoDocumentoCard { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
    }
}
