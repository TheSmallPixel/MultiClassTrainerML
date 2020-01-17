using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabInvaliditaCoeff
    {
        public int IdTabInvaliditaCoeff { get; set; }
        public int IdDannoBiologico { get; set; }
        public decimal PercCoefficiente { get; set; }
        public decimal Eta { get; set; }
    }
}
