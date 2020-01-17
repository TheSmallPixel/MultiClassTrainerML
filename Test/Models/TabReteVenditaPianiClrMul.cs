using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaPianiClrMul
    {
        public int KeyRetevenditaPianoClrMul { get; set; }
        public int IdRetevenditaPianoClrMul { get; set; }
        public int IdRetevenditaPianoClr { get; set; }
        public int IdRetevendita { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
