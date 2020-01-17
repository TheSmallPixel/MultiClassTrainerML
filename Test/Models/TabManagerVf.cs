using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabManagerVf
    {
        public decimal KeyManagerVf { get; set; }
        public decimal IdManagerVf { get; set; }
        public string CodManagerVf { get; set; }
        public decimal IdAnagrafica { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdUtente { get; set; }
    }
}
