using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class OperazioniStati
    {
        public int IdOperazioniStati { get; set; }
        public int IdStatoOperazione { get; set; }
        public int IdOggetto { get; set; }
        public string FlgTipoOggetto { get; set; }
        public DateTime DtEsecuzione { get; set; }
        public int IdUtente { get; set; }
    }
}
