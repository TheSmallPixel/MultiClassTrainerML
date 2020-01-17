using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabAssegnazioneLiquidatori
    {
        public int KeyAssegnazioneLiquidatori { get; set; }
        public int IdAssegnazioneLiquidatori { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
        public int IdLiquidatore { get; set; }
        public int IdIspettorato { get; set; }
        public int IdReteVendita { get; set; }
        public DateTime? DtInizioValidita { get; set; }
        public DateTime? DtFineValidita { get; set; }
    }
}
