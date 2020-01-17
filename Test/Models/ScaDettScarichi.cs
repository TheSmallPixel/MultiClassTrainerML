using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ScaDettScarichi
    {
        public decimal IdDettaglioscarico { get; set; }
        public decimal IdScarico { get; set; }
        public decimal IdStoricoEntitaScaricata { get; set; }
        public decimal IdEntitaScaricata { get; set; }

        public virtual ScaScarichi IdScaricoNavigation { get; set; }
    }
}
