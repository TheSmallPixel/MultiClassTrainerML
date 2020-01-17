using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class QuiProdotti
    {
        public decimal IdQuiProdotto { get; set; }
        public decimal IdQuiLogQuietanza { get; set; }
        public decimal IdPrProdotto { get; set; }
        public DateTime? DtVersione { get; set; }

        public virtual QuiLogQuietanze IdQuiLogQuietanzaNavigation { get; set; }
    }
}
