using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AnaAllegati
    {
        public decimal KeyAnaAllegato { get; set; }
        public decimal IdAnaAllegato { get; set; }
        public decimal IdAnagrafica { get; set; }
        public decimal IdAllegato { get; set; }
        public decimal IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
