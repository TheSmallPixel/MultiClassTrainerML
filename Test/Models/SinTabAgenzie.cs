using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinTabAgenzie
    {
        public int KeySinTabAgenzie { get; set; }
        public int? IdCompagnia { get; set; }
        public string CodAgenzia { get; set; }
        public string FlgDirezione { get; set; }
        public string FlgEsclusione { get; set; }
    }
}
