using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrCoefRisMatematica
    {
        public decimal KeyPrCoefRisMatematica { get; set; }
        public decimal? IdPrCoefRisMatematica { get; set; }
        public decimal? IdPrGarTariffa { get; set; }
        public string ValoreParametri { get; set; }
        public decimal? TassoRisMatematica { get; set; }
        public decimal? TassoRisSpese { get; set; }
        public decimal? Antidurata { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? TassoPremioPuro { get; set; }
    }
}
