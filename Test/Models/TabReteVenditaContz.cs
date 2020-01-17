using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaContz
    {
        public int KeyRetevenditaContz { get; set; }
        public int IdRetevenditaContz { get; set; }
        public string FlgDisattivaFunzOnlineSino { get; set; }
        public DateTime? DtDisattivaFunzOnline { get; set; }
        public string FlgValdisattFunzOnlineSino { get; set; }
        public DateTime? DtValdisattFunzOnline { get; set; }
        public int IdRetevendita { get; set; }
        public string CodGestione { get; set; }
        public int? IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
