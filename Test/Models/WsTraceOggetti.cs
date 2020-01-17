using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class WsTraceOggetti
    {
        public int IdWsTraceOggetto { get; set; }
        public int IdWsTraceChiamata { get; set; }
        public string FlgTipoOggetto { get; set; }
        public int IdOggetto { get; set; }
    }
}
