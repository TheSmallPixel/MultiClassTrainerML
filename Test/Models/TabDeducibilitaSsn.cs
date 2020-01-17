using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabDeducibilitaSsn
    {
        public decimal IdDeducibilitaSsn { get; set; }
        public DateTime? DtInizioValidita { get; set; }
        public DateTime? DtFineValidita { get; set; }
        public decimal? PercDeducibilita { get; set; }
    }
}
