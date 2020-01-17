using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrTipoRetiVendita
    {
        public decimal KeyPrTipoReteVendita { get; set; }
        public decimal? IdPrTipoReteVendita { get; set; }
        public string FlgTipoEntitaProd { get; set; }
        public decimal? IdPrRamo { get; set; }
        public decimal? IdPrProdotto { get; set; }
        public decimal? IdUtente { get; set; }
        public string FlgTipoReteVendita { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
