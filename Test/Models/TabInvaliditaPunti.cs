using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabInvaliditaPunti
    {
        public int IdTabInvaliditaPunti { get; set; }
        public int IdDannoBiologico { get; set; }
        public decimal PuntoInv { get; set; }
        public decimal Imp100 { get; set; }
        public decimal PercMaxPers { get; set; }
    }
}
