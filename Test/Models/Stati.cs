using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Stati
    {
        public int KeyStato { get; set; }
        public int IdStato { get; set; }
        public int IdStatoOggetto { get; set; }
        public int IdOggetto { get; set; }
        public string FlgTipoOggetto { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
        public int? IdOperazioniStati { get; set; }
    }
}
