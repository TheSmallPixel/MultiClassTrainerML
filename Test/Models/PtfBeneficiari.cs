using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PtfBeneficiari
    {
        public decimal KeyBeneficiario { get; set; }
        public decimal? IdBeneficiario { get; set; }
        public decimal? IdAnagrafica { get; set; }
        public string NoteBeneficiario { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdBene { get; set; }
    }
}
