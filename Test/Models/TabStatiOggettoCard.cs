using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabStatiOggettoCard
    {
        public int IdStatoOggettoCard { get; set; }
        public int IdStatoOggetto { get; set; }
        public string Flusso { get; set; }
        public string FlgPermessaNotaConcardSino { get; set; }
    }
}
