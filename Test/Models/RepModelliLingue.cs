using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RepModelliLingue
    {
        public decimal IdModelloLingua { get; set; }
        public decimal IdModello { get; set; }
        public decimal IdLingua { get; set; }
        public decimal IdAreaDati { get; set; }

        public virtual SysLingue IdLinguaNavigation { get; set; }
        public virtual RepModelli IdModelloNavigation { get; set; }
    }
}
