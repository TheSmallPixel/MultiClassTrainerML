using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabLiquidatori
    {
        public decimal KeyLiquidatore { get; set; }
        public decimal IdLiquidatore { get; set; }
        public string CodLiquidatore { get; set; }
        public DateTime DtIniRapporto { get; set; }
        public DateTime DtFinRapporto { get; set; }
        public decimal IdAnagrafica { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal IdUtente { get; set; }
        public string FlgAmministrativoSino { get; set; }
    }
}
