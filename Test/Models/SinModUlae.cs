using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinModUlae
    {
        public int KeySinModUlae { get; set; }
        public int? IdCompagnia { get; set; }
        public string AnnoCompetenza { get; set; }
        public string CodRamo { get; set; }
        public decimal? ImpRiservaFinAp { get; set; }
        public decimal? ImpRiservaFinAc { get; set; }
        public decimal? ImpSpeseAp { get; set; }
        public decimal? ImpSpeseAc { get; set; }
    }
}
