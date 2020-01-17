using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaFidejussioni
    {
        public decimal KeyFidejussione { get; set; }
        public decimal IdFidejussione { get; set; }
        public decimal IdAbi { get; set; }
        public decimal IdCab { get; set; }
        public decimal Importo { get; set; }
        public DateTime DtRilascio { get; set; }
        public DateTime DtScadenza { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal IdUtente { get; set; }
    }
}
