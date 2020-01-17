using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrRetiVendita
    {
        public decimal KeyPrReteVendita { get; set; }
        public decimal? IdPrReteVendita { get; set; }
        public string FlgTipoEntitaProd { get; set; }
        public decimal? IdPrRamo { get; set; }
        public decimal? IdPrProdotto { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal? IdRetevendita { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgDerogabileSino { get; set; }
        public string FlgPropostaDerogabileSino { get; set; }
        public decimal? CodDeroga { get; set; }
        public decimal? CodDerogaProposta { get; set; }
    }
}
