using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrCoeffIstat
    {
        public decimal KeyCoeffIstat { get; set; }
        public decimal IdCoeffIstat { get; set; }
        public decimal IdIstat { get; set; }
        public decimal? IndiceIndicizzazione { get; set; }
        public decimal? PercVariazione { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }

        public virtual PrIstat IdIstatNavigation { get; set; }
    }
}
