using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabCodGarBp
    {
        public int IdTabCodBp { get; set; }
        public string FlgEnteErogatore { get; set; }
        public int? IdPrProdotto { get; set; }
        public int? IdPrGaranzia { get; set; }
        public int? IdPrPacchetto { get; set; }
        public int? IdPrValParametro { get; set; }
        public string CodiceBp { get; set; }
    }
}
