﻿using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrModelliProdotti
    {
        public decimal KeyPrModelloProdotto { get; set; }
        public decimal IdPrModelloProdotto { get; set; }
        public decimal IdModello { get; set; }
        public decimal IdPrProdotto { get; set; }
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

        public virtual RepModelli IdModelloNavigation { get; set; }
    }
}
