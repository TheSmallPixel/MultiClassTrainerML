using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrProdottiConvenzioni
    {
        public decimal KeyPrProdottoConvenzione { get; set; }
        public decimal IdPrProdottoConvenzione { get; set; }
        public decimal IdPrProdotto { get; set; }
        public decimal IdConvenzione { get; set; }
        public decimal IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }

        public virtual TabConvenzioni IdConvenzioneNavigation { get; set; }
    }
}
