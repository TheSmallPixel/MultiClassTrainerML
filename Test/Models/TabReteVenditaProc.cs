using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaProc
    {
        public decimal KeyRetevenditaProc { get; set; }
        public decimal IdRetevenditaProc { get; set; }
        public decimal IdRetevendita { get; set; }
        public decimal IdAnagrafica { get; set; }
        public DateTime? DtProcuratoreDal { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtCessazione { get; set; }
        public string CodGestione { get; set; }
        public string FlgAxaCampus { get; set; }
        public DateTime? DtAxaCampus { get; set; }
    }
}
