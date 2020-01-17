using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysJobAvvisi
    {
        public decimal IdJobAvviso { get; set; }
        public decimal IdJob { get; set; }
        public decimal IdUtente { get; set; }

        public virtual SysJob IdJobNavigation { get; set; }
    }
}
