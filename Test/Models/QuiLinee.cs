using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class QuiLinee
    {
        public decimal IdQuiLinea { get; set; }
        public decimal IdQuiLogQuietanza { get; set; }
        public decimal IdPrLineaProdotto { get; set; }

        public virtual QuiLogQuietanze IdQuiLogQuietanzaNavigation { get; set; }
    }
}
