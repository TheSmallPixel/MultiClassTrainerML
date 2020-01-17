using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaLeadMan
    {
        public int KeyLeadMan { get; set; }
        public int IdLeadMan { get; set; }
        public int IdRetevendita { get; set; }
        public string CodGestione { get; set; }
        public int? NumDp2 { get; set; }
        public int? NumDpmi { get; set; }
        public int? PunteggioAuto { get; set; }
        public int? PunteggioRetail { get; set; }
        public int? PunteggioCommercialLines { get; set; }
        public int? PunteggioVita { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
        public decimal? PerCrAuto { get; set; }
        public decimal? PerCrRetail { get; set; }
        public decimal? PerCrCommercialLines { get; set; }
        public decimal? PerCrVita { get; set; }
    }
}
