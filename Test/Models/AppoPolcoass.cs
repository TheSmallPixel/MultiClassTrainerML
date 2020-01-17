using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AppoPolcoass
    {
        public decimal? IdPolCoass { get; set; }
        public decimal IdPolizza { get; set; }
        public string FlgTipoCompCoass { get; set; }
        public string CodCompagnia { get; set; }
        public string CodAgeCoass { get; set; }
        public decimal PctQuota { get; set; }
        public string NPolizzaDelegataria { get; set; }
    }
}
