using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrFrazAmmessi
    {
        public decimal KeyPrFrazAmmesso { get; set; }
        public decimal? IdPrFrazAmmesso { get; set; }
        public decimal? IdPrFrazionamento { get; set; }
        public decimal? IdPrRamo { get; set; }
        public decimal? IdPrProdotto { get; set; }
        public decimal? IdUtente { get; set; }
        public string FlgTipoEntitaProd { get; set; }
        public decimal PctInteressi { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgAmmessoPolBaseSino { get; set; }
    }
}
