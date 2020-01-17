using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabFormule
    {
        public decimal KeyFormula { get; set; }
        public decimal IdFormula { get; set; }
        public string FlgTipoFormula { get; set; }
        public decimal IdDescFormula { get; set; }
        public string FlgValidaSino { get; set; }
        public string Formula { get; set; }
        public decimal IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string DescFormula { get; set; }
        public string CodFormula { get; set; }
        public string ParoleChiave { get; set; }
    }
}
