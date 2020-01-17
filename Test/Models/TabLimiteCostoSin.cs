using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabLimiteCostoSin
    {
        public int IdLimiteCostoSin { get; set; }
        public int IdCompagnia { get; set; }
        public int AnnoEsercizio { get; set; }
        public decimal ImpLimiteCosto { get; set; }
    }
}
