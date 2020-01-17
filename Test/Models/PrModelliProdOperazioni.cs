using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrModelliProdOperazioni
    {
        public decimal KeyPrModelloProdOperazione { get; set; }
        public decimal IdPrModelloProdOperazione { get; set; }
        public decimal IdModello { get; set; }
        public decimal IdPrProdOperazione { get; set; }
        public string FlgNostraDelegaSino { get; set; }
        public string FlgAltruiDelegaSino { get; set; }
        public string FlgPropostaSino { get; set; }
        public string FlgObbligoStampaSino { get; set; }
        public decimal IdUtente { get; set; }
        public string FlgEsclusivaSino { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgDupWatermarkSino { get; set; }
    }
}
