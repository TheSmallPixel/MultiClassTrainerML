using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TitPagatore
    {
        public decimal KeyTitPagatore { get; set; }
        public decimal IdTitPagatore { get; set; }
        public string FlgLegameContraente { get; set; }
        public decimal? IdAnagrafica { get; set; }
        public decimal? IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
