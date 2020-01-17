using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Dp2PianoFormativo
    {
        public decimal KeyDp2PianoFormativo { get; set; }
        public decimal IdDp2PianoFormativo { get; set; }
        public decimal IdDp2DatiGenerali { get; set; }
        public string FlgUnitaFormativa { get; set; }
        public string FlgCertificazioneSino { get; set; }
        public DateTime? DtCertificazione { get; set; }
        public string FlgDocenza { get; set; }
        public decimal? IdAnagrafica { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdUtente { get; set; }
    }
}
