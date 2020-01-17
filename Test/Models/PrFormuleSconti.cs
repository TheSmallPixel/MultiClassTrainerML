using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrFormuleSconti
    {
        public int KeyPrFormuleSconti { get; set; }
        public int IdPrFormuleSconti { get; set; }
        public int IdPrProdotto { get; set; }
        public int IdFormula { get; set; }
        public int? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
