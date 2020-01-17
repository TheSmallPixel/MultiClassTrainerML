using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PtfTariffeBeni
    {
        public int IdTariffaBene { get; set; }
        public int IdBene { get; set; }
        public int IdPolizza { get; set; }
        public string CodTariffa { get; set; }
    }
}
