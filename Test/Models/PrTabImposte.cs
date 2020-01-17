using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrTabImposte
    {
        public decimal KeyPrTabImposta { get; set; }
        public decimal? IdPrTabImposta { get; set; }
        public string FlgTipoImposta { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal? PctImposta { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdProvincia { get; set; }
        public decimal? PctVariazione { get; set; }
    }
}
