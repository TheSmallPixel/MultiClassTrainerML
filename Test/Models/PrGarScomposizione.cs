using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrGarScomposizione
    {
        public decimal KeyPrGarScomposizione { get; set; }
        public decimal? IdPrGarScomposizione { get; set; }
        public decimal? IdPrGaranzia { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal? PctScomposizione { get; set; }
        public string FlgPrincipaleSino { get; set; }
        public decimal? IdPrGarTariffa { get; set; }
        public string CodGaranzia { get; set; }
        public decimal? IdDescGaranzia { get; set; }
        public decimal? IdPrGarTariffaRinnovo { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string DescGaranzia { get; set; }
        public decimal? CoeffVarTariffa { get; set; }
        public decimal? CoeffVarTariffaRinnovo { get; set; }
        public string FlgCreaIncaricoSino { get; set; }
    }
}
