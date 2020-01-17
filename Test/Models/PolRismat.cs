using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolRismat
    {
        public decimal IdPolRismat { get; set; }
        public decimal IdPolGaranzia { get; set; }
        public decimal AnnoElab { get; set; }
        public decimal MeseElab { get; set; }
        public decimal? ImpCapitaleResiduo { get; set; }
        public decimal? ImpRiservaMatematica { get; set; }
        public decimal? ImpRiservaMatematicaSpe { get; set; }
        public decimal IdPolizza { get; set; }
        public decimal? ImpRiservaMatBil { get; set; }
        public decimal? ImpRipPremioPuroAnnuo { get; set; }
        public decimal? ImpRatePremioFutRp { get; set; }
    }
}
