using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Dp2PianoContr
    {
        public decimal KeyDp2PianoContr { get; set; }
        public decimal IdDp2PianoContr { get; set; }
        public string FlgTipoPiano { get; set; }
        public string FlgModelloContributivo { get; set; }
        public DateTime? DtSviluppoPiano { get; set; }
        public DateTime? DtFinePiano { get; set; }
        public decimal? CreditoIngresso { get; set; }
        public string NoteErogazione { get; set; }
        public DateTime? DtPassagioPiano { get; set; }
        public DateTime? DtPassagioPianoTrimestrale { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdUtente { get; set; }
    }
}
