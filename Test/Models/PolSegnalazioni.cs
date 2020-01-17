using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolSegnalazioni
    {
        public decimal KeyPolSegnalazione { get; set; }
        public decimal IdPolAutorizzazione { get; set; }
        public string CodErrore { get; set; }
        public string AltriDati { get; set; }
        public decimal IdPolizza { get; set; }
        public int? CodLivelloDeroga { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
