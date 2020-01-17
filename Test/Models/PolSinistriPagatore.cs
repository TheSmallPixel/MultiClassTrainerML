using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolSinistriPagatore
    {
        public decimal KeyPolSinistroPagatore { get; set; }
        public decimal IdPolSinistroPagatore { get; set; }
        public string FlgLegameContraente { get; set; }
        public decimal? IdAnagrafica { get; set; }
        public decimal? IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
