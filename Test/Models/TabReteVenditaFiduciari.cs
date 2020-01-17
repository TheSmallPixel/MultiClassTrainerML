using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaFiduciari
    {
        public decimal IdRetevenditaFiduciari { get; set; }
        public decimal IdRetevendita { get; set; }
        public decimal IdFiduciario { get; set; }
        public DateTime? DtIniRapporto { get; set; }
        public DateTime? DtFinRapporto { get; set; }
    }
}
