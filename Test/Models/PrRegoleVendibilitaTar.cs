using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrRegoleVendibilitaTar
    {
        public int KeyPrRegolaVendibilitaTar { get; set; }
        public int? IdPrRegolaVendibilitaTar { get; set; }
        public int? IdPrGarTariffa { get; set; }
        public int? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgCampoTariffa { get; set; }
        public string FlgCondizione { get; set; }
        public int? IdPrGarTariffaCompar { get; set; }
        public int? PrgOr { get; set; }
        public string FlgDerogabileSino { get; set; }
        public decimal? CodDeroga { get; set; }
    }
}
