using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinEcAltridati
    {
        public int KeyEcAltridati { get; set; }
        public int IdEcAltridati { get; set; }
        public int IdEntitacoinvolta { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgParticolaritaDannoCose { get; set; }
    }
}
