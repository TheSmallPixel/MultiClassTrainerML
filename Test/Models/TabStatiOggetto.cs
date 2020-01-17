using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabStatiOggetto
    {
        public int IdStatoOggetto { get; set; }
        public int IdTipoOggetto { get; set; }
        public string FlgStatoOggetto { get; set; }
        public string Descrizione { get; set; }
        public string FlgTipologiaCruscotto { get; set; }
        public string FlgStatoFinaleSino { get; set; }
    }
}
