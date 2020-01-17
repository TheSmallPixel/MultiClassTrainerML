using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CauUdienze
    {
        public decimal KeyUdienza { get; set; }
        public decimal IdUdienza { get; set; }
        public DateTime DtUdienza { get; set; }
        public string NoteMotivoRinvio { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal IdCausa { get; set; }
    }
}
