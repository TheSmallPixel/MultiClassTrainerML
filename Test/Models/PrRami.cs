using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrRami
    {
        public decimal KeyPrRamo { get; set; }
        public decimal IdPrRamo { get; set; }
        public decimal? IdUtente { get; set; }
        public string CodRamo { get; set; }
        public decimal IdDescRamo { get; set; }
        public string FlgRetiAbilSino { get; set; }
        public string FlgPuntiAbilSino { get; set; }
        public decimal? IdPrLineaProdotto { get; set; }
        public string FlgTipoRamo { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string DescRamo { get; set; }
    }
}
