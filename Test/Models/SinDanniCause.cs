using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinDanniCause
    {
        public int KeyDanniCausa { get; set; }
        public int IdDannoCausa { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public int? IdDanno { get; set; }
        public string FlgCausaSino { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdCausa { get; set; }
    }
}
