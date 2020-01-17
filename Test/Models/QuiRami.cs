using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class QuiRami
    {
        public decimal IdQuiRamo { get; set; }
        public decimal IdQuiLogQuietanza { get; set; }
        public decimal IdPrRamo { get; set; }

        public virtual QuiLogQuietanze IdQuiLogQuietanzaNavigation { get; set; }
    }
}
