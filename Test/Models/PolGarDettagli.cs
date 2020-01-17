using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolGarDettagli
    {
        public decimal KeyPolGarDettaglio { get; set; }
        public decimal? IdPolGarDettaglio { get; set; }
        public decimal? IdPolGaranzia { get; set; }
        public string FlgRamoBilancio { get; set; }
        public string FlgCatTariffa { get; set; }
        public decimal? IdPrGarScomposizione { get; set; }
        public decimal? PctScomposizione { get; set; }
        public decimal? IdPolizza { get; set; }
        public decimal IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
