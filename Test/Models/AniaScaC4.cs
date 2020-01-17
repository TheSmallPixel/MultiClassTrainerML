using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaScaC4
    {
        public int IdAniaScaC4 { get; set; }
        public int IdAniaScaC { get; set; }
        public int IdAniaScaA { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public string RifAniaPraticaDaStornare { get; set; }
        public decimal? ImpDaCaricare { get; set; }
    }
}
