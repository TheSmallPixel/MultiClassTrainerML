using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Dp2PianoContrMese
    {
        public decimal KeyDp2PianoContrMese { get; set; }
        public decimal IdDp2PianoContrMese { get; set; }
        public decimal IdDp2PianoContr { get; set; }
        public decimal MesePiano { get; set; }
        public decimal AnnoPiano { get; set; }
        public decimal? ObiettivoMese { get; set; }
        public decimal? ObiettivoMeseCumulato { get; set; }
        public decimal? ContributoMese { get; set; }
        public decimal? ContributoMeseCumulato { get; set; }
        public decimal? ContributoBonus { get; set; }
        public decimal? ContributoErogatoMese { get; set; }
        public decimal? Target { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdUtente { get; set; }
    }
}
