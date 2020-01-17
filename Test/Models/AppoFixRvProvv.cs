using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AppoFixRvProvv
    {
        public int KeyEvento { get; set; }
        public string DtSysEvento { get; set; }
        public DateTime? DtEvento { get; set; }
        public int IdCompagnia { get; set; }
        public int IdPolizza { get; set; }
        public string NPolizza { get; set; }
        public int IdGaranzia { get; set; }
        public int? KeyProvvigioneOrig { get; set; }
        public int? IdProvvigioneOrig { get; set; }
        public int? IdRetevenditaOrig { get; set; }
        public int? LivelloOrig { get; set; }
        public int KeyProvvigioneFix { get; set; }
        public int IdProvvigioneFix { get; set; }
        public int? IdRetevenditaFix { get; set; }
        public int? LivelloFix { get; set; }
        public string TimestampElaborazione { get; set; }
        public string Esito { get; set; }
    }
}
