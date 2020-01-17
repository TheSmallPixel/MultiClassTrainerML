using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CtbRiserveMigrazione
    {
        public int IdRiservemigrazione { get; set; }
        public int IdSinistro { get; set; }
        public int Anno { get; set; }
        public decimal RisFPassanti { get; set; }
        public decimal RisFTrasportati { get; set; }
        public decimal RisFCose { get; set; }
        public decimal RisFSpResistenza { get; set; }
        public decimal RisFSpLiquidazione { get; set; }
        public decimal RisFVeicoli { get; set; }
        public decimal RisFRivalsa { get; set; }
        public decimal RisFForfait2007 { get; set; }
        public decimal RisFForfaitCard { get; set; }
        public decimal RisFForfaitLesioni { get; set; }
        public decimal RisFForfaitCtt { get; set; }
    }
}
