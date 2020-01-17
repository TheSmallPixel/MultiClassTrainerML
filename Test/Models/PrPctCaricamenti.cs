using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrPctCaricamenti
    {
        public int KeyPrPctCaricamento { get; set; }
        public int IdPrPctCaricamento { get; set; }
        public int IdPrGarTariffa { get; set; }
        public decimal PctCaricamento { get; set; }
        public int? IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string ValoreParametri { get; set; }
    }
}
