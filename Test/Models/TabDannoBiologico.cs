using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabDannoBiologico
    {
        public int IdDannoBiologico { get; set; }
        public string FlgTabellaDannoBiologico { get; set; }
        public decimal Anno { get; set; }
        public decimal ImpDannoTemporaneo { get; set; }
        public decimal PercMaxPersTemporaneo { get; set; }
    }
}
