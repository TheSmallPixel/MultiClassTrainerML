using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabDetraibilita
    {
        public decimal IdDetraibilita { get; set; }
        public decimal IdCompagnia { get; set; }
        public DateTime? DtInizioValidita { get; set; }
        public DateTime? DtFineValidita { get; set; }
        public string FlgRamoBilancio { get; set; }
        public decimal? PercFranchigiaDa { get; set; }
        public decimal? PercFranchigiaA { get; set; }
        public decimal? PercDetraibilita { get; set; }
    }
}
