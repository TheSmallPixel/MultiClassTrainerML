using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Dp2Note
    {
        public decimal KeyDp2Note { get; set; }
        public decimal IdDp2Note { get; set; }
        public decimal IdDp2DatiGenerali { get; set; }
        public DateTime DtNota { get; set; }
        public string Nota { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdUtente { get; set; }
    }
}
