using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaAtrcSinparitari
    {
        public int IdAtrcSinparitario { get; set; }
        public int IdRichiestaAtrc { get; set; }
        public int IdRichiestaIbd { get; set; }
        public int? AnnoRiferimento { get; set; }
        public int? Progressivo { get; set; }
        public decimal? Percentuale { get; set; }
        public string TipologiaDanno { get; set; }
        public string FlgBonusMalus { get; set; }
    }
}
