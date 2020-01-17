using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolRichiesteRegolazione
    {
        public decimal KeyPolRichiesteRegolazione { get; set; }
        public decimal? IdPolRegPremio { get; set; }
        public decimal? IdPolizza { get; set; }
        public DateTime? DtInvioRichiesta { get; set; }
        public DateTime? DtSysRichiesta { get; set; }
        public string FlgTipoRichiestaRegolazione { get; set; }
        public string Note { get; set; }
        public decimal IdUtente { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
