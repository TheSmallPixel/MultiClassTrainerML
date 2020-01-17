using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrPacchetti
    {
        public int KeyPrPacchetto { get; set; }
        public int? IdPrPacchetto { get; set; }
        public string CodPacchetto { get; set; }
        public int? IdDescPacchetto { get; set; }
        public string DescPacchetto { get; set; }
        public int? Ordine { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
        public int? IdPrSezione { get; set; }
        public string TooltipInfo { get; set; }
    }
}
