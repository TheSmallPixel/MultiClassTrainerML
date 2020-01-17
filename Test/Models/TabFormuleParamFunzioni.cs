using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabFormuleParamFunzioni
    {
        public int KeyFormulaParamFunzione { get; set; }
        public int IdFormulaParamFunzione { get; set; }
        public int IdFormula { get; set; }
        public int? PrgParametro { get; set; }
        public string FlgFormatoVariabile { get; set; }
        public int? IdDescrizione { get; set; }
        public string Descrizione { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
