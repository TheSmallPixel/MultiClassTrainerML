using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabPuntiVenditaProd
    {
        public decimal KeyPuntoVenditaProd { get; set; }
        public decimal? IdPuntoVenditaProd { get; set; }
        public string FlgAbilitatoSino { get; set; }
        public decimal? IdRetevendita { get; set; }
        public decimal? IdProdotto { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdUtente { get; set; }
    }
}
