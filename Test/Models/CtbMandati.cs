using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CtbMandati
    {
        public decimal KeyMandato { get; set; }
        public decimal IdMandato { get; set; }
        public string FlgTipoMandato { get; set; }
        public decimal? Numero { get; set; }
        public DateTime? DtMandato { get; set; }
        public decimal? IdCcCompagnia { get; set; }
        public decimal? IdCcBeneficiario { get; set; }
        public string FlgStatoMandato { get; set; }
        public decimal? IdCompagnia { get; set; }
        public string DtStoEffettoFis { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtPagamento { get; set; }
        public decimal? IdBeneficiario { get; set; }
        public string FlgMezzoPagamento { get; set; }
        public string CodRamoProdotto { get; set; }
        public string Causale { get; set; }
    }
}
