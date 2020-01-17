using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabLegameAnagrafe
    {
        public decimal IdTabLegame { get; set; }
        public string CodiceLegame { get; set; }
        public decimal? IdDescLegame { get; set; }
        public decimal? IdLegameRiferimento { get; set; }
        public string FlgLegameParentelaSino { get; set; }
        public string FlgReadOnlySino { get; set; }
        public decimal? GradoParentela { get; set; }
        public string DescLegame { get; set; }
    }
}
