using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabRaccordiGarDanni
    {
        public int KeyRaccordoGarDanno { get; set; }
        public int IdRaccordoGarDanno { get; set; }
        public int IdGaranzia { get; set; }
        public string FlgTipologiaDanno { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
    }
}
