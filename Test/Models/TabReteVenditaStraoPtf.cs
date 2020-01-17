using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaStraoPtf
    {
        public decimal KeyRetevenditaStraoPtf { get; set; }
        public decimal IdRetevenditaStraoPtf { get; set; }
        public decimal IdRetevendita { get; set; }
        public DateTime? DtDal { get; set; }
        public DateTime? DtAl { get; set; }
        public string Note { get; set; }
        public string FlgEventoStraoPtf { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdUtente { get; set; }
        public string CodGestione { get; set; }
    }
}
