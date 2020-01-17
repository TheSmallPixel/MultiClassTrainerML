using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolVincoliTesti
    {
        public decimal KeyPolTestoVincolo { get; set; }
        public decimal IdPolTestoVincolo { get; set; }
        public decimal IdPolVincolo { get; set; }
        public decimal? IdAllegato { get; set; }
        public decimal? IdModello { get; set; }
        public decimal? IdModVincolataria { get; set; }
        public decimal? IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }

        public virtual PrModelliVincolatarie IdModVincolatariaNavigation { get; set; }
    }
}
