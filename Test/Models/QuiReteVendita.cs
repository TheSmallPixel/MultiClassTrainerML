using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class QuiReteVendita
    {
        public decimal IdQuiReteVendita { get; set; }
        public decimal IdQuiLogQuietanza { get; set; }
        public decimal IdRetevendita { get; set; }

        public virtual QuiLogQuietanze IdQuiLogQuietanzaNavigation { get; set; }
    }
}
