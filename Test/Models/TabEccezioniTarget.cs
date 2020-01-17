using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabEccezioniTarget
    {
        public int IdEccezioneTarget { get; set; }
        public int IdTarget { get; set; }
        public int IdOggettoTarget { get; set; }
        public string FlgTipoOggettoTarget { get; set; }
    }
}
