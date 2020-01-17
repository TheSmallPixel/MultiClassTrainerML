using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabIspettAmm
    {
        public decimal KeyIspettoreAmm { get; set; }
        public decimal IdIspettoreAmm { get; set; }
        public string CodIspettoreAmm { get; set; }
        public decimal IdAnagrafica { get; set; }
        public decimal IdDipartimento { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdUtente { get; set; }
    }
}
