using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrPerfezionamenti
    {
        public decimal IdPrPerfezionamento { get; set; }
        public decimal? GgPerfezionamento { get; set; }
        public DateTime? DtPerfezionamento { get; set; }
        public decimal IdPrProdotto { get; set; }
    }
}
