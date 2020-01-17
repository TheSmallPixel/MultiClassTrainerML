using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabCalcoliAutomatici
    {
        public decimal KeyCalcoloautomatico { get; set; }
        public decimal IdCalcoloautomatico { get; set; }
        public decimal PerIva { get; set; }
        public decimal PerCpa { get; set; }
        public decimal PerRitenuta { get; set; }
        public decimal IdCompagnia { get; set; }
        public string FlgIvaSuCpaSino { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal IdUtente { get; set; }
        public decimal? PerInps { get; set; }
        public string FlgIvaSuInpsSino { get; set; }
        public string FlgRitSuInpsSino { get; set; }
        public string FlgRitSuCpaSino { get; set; }
    }
}
