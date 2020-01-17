using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrGarPacchetti
    {
        public int KeyPrGarPacchetto { get; set; }
        public int? IdPrGarPacchetto { get; set; }
        public int? IdPrPacchetto { get; set; }
        public int? IdPrGaranzia { get; set; }
        public int? Ordine { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
    }
}
