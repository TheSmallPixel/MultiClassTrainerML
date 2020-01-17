using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabTargetScadenze
    {
        public int IdTarget { get; set; }
        public int IdScadenzaStatoOggetto { get; set; }
        public int? IdOggettoTarget { get; set; }
        public string FlgTipoOggettoTarget { get; set; }
        public int? OffsetGiorniLavorativi { get; set; }
        public string Email { get; set; }
    }
}
