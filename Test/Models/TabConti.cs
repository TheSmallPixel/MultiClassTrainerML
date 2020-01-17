using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabConti
    {
        public decimal KeyConto { get; set; }
        public decimal IdConto { get; set; }
        public decimal IdCompagnia { get; set; }
        public string CodContoComm { get; set; }
        public decimal IdDescContoComm { get; set; }
        public string CodContoCoge { get; set; }
        public decimal IdDescContoCoge { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal IdUtente { get; set; }
        public string DescContoComm { get; set; }
        public string DescContoCoge { get; set; }
    }
}
