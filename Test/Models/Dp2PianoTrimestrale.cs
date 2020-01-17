using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Dp2PianoTrimestrale
    {
        public decimal KeyPianoTrimestrale { get; set; }
        public decimal IdPianoTrimestrale { get; set; }
        public decimal IdDp2DatiGenerali { get; set; }
        public string FlgTrimestre { get; set; }
        public decimal? ContributoErogato { get; set; }
        public string Note { get; set; }
        public decimal? AaPagamentoPna { get; set; }
        public decimal? MmPagamentoPna { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdUtente { get; set; }
    }
}
