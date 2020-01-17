using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaScaC6
    {
        public int IdAniaScaC6 { get; set; }
        public int IdAniaScaC { get; set; }
        public int IdAniaScaA { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public string FlgTipoDanno { get; set; }
        public string FlgRuoloDanneggiato { get; set; }
        public string ConvenzioneCard { get; set; }
        public string ProvinciaResidenzaProp { get; set; }
        public string IdentPartitaDanno { get; set; }
        public string IdentSinistro { get; set; }
        public string NominativoDanneggiato { get; set; }
        public string CfPivaDanneggiato { get; set; }
    }
}
