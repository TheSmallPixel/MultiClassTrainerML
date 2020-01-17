using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabTipiOggetto
    {
        public int IdTipoOggetto { get; set; }
        public string FlgTipoOggetto { get; set; }
        public string Descrizione { get; set; }
        public string FlgNascondiTipoCruscotto { get; set; }
        public string FlgNascondiStatoFinale { get; set; }
        public string FlgNascondiDescTransizione { get; set; }
        public string FlgNascondiDefault { get; set; }
        public string FlgNascondiFrizzabile { get; set; }
        public string FlgNascondiRitroso { get; set; }
    }
}
