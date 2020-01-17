using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaScaC5
    {
        public int IdAniaScaC5 { get; set; }
        public int IdAniaScaC { get; set; }
        public int IdAniaScaA { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public string IdentPartitaDanno { get; set; }
        public string CodFisDanneggiato { get; set; }
        public string NominativoDanneggiato { get; set; }
        public string FlgRuoloDanneggiato { get; set; }
    }
}
