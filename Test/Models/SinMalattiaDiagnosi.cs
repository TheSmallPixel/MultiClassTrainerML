using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinMalattiaDiagnosi
    {
        public int KeyMalattiadiagnosi { get; set; }
        public int IdMalattiadiagnosi { get; set; }
        public string FlgDiagnosi { get; set; }
        public string FlgTipoDiagnosi { get; set; }
        public string Note { get; set; }
        public int IdMalattiatrattamento { get; set; }
        public int IdEntitacoinvolta { get; set; }
        public int IdSinistro { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
