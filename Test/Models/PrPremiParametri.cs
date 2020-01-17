using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrPremiParametri
    {
        public decimal KeyPrPremiParametro { get; set; }
        public decimal? IdPrPremiParametro { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal? ImpParametro { get; set; }
        public decimal? CoefParametro { get; set; }
        public decimal? PuntiParametro { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
