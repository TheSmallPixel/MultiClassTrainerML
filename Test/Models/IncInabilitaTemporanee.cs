using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class IncInabilitaTemporanee
    {
        public int KeyIncaricoinabilitatemp { get; set; }
        public int IdIncaricoinabilitatemp { get; set; }
        public int IdSinistro { get; set; }
        public int IdEntitacoinvolta { get; set; }
        public int IdIncarico { get; set; }
        public int IdIncaricodannocorporale { get; set; }
        public int? NumeroGiorni { get; set; }
        public decimal? PctInabilita { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
