using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaScaC3
    {
        public int IdAniaScaC3 { get; set; }
        public int IdAniaScaC { get; set; }
        public int IdAniaScaA { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public string IdentSinistroMittente { get; set; }
        public decimal? ImpDanno { get; set; }
        public decimal? ImpRimborso { get; set; }
        public decimal? ImpDirittiGestione { get; set; }
        public decimal? PercRespMittente { get; set; }
        public decimal? PercRespControparte { get; set; }
    }
}
