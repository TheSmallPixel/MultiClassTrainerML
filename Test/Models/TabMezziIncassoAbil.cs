using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabMezziIncassoAbil
    {
        public decimal IdMezzoincassoabil { get; set; }
        public decimal IdRetevendita { get; set; }
        public string FlgMezzoIncassoPolizza { get; set; }
        public string FlgPredefinitoSino { get; set; }
    }
}
