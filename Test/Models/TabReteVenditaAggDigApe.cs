using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaAggDigApe
    {
        public int KeyAggDigApe { get; set; }
        public int IdAggDigApe { get; set; }
        public int IdAggDig { get; set; }
        public int Giorno { get; set; }
        public string HhmmAp1 { get; set; }
        public string HhmmCh1 { get; set; }
        public string HhmmAp2 { get; set; }
        public string HhmmCh2 { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
