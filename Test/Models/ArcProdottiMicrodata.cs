using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcProdottiMicrodata
    {
        public decimal IdProdottoMicrodata { get; set; }
        public decimal IdPrProdotto { get; set; }
        public string CodProdotto { get; set; }
        public string DescProdotto { get; set; }
        public DateTime DtEffetto { get; set; }
    }
}
