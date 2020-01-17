using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Dp2PremiAggiuntivi
    {
        public decimal KeyPremiAggiuntivi { get; set; }
        public decimal IdPremiAggiuntivi { get; set; }
        public decimal IdDp2DatiGenerali { get; set; }
        public string Contesto { get; set; }
        public decimal? ImpPremio { get; set; }
        public decimal? MmErogazione { get; set; }
        public decimal? AaErogazione { get; set; }
        public string Note { get; set; }
        public string FlgTipologiaPremio { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdUtente { get; set; }
    }
}
