using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrClassiRischioDett
    {
        public int IdPrClasseRischioDett { get; set; }
        public int IdPrClasseRischio { get; set; }
        public string CodMarca { get; set; }
        public string CodModello { get; set; }
        public string CodAllestimento { get; set; }
    }
}
