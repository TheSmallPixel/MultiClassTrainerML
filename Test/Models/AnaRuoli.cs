using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AnaRuoli
    {
        public decimal IdAnagrafica { get; set; }
        public decimal IdRuolo { get; set; }

        public virtual TabRuoli IdRuoloNavigation { get; set; }
    }
}
