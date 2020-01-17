using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class WsTraceChiamate
    {
        public int IdWsTraceChiamata { get; set; }
        public string FlgTipoRichiesta { get; set; }
        public string Operazione { get; set; }
        public string TestoRequest { get; set; }
        public string TestoResponse { get; set; }
        public string TimestampRichiesta { get; set; }
        public string FlgEsitoChiamata { get; set; }
    }
}
