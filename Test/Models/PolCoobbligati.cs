using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolCoobbligati
    {
        public int KeyPolCoobbligato { get; set; }
        public int? IdPolCoobbligato { get; set; }
        public decimal IdPolizza { get; set; }
        public int IdAnagrafica { get; set; }
        public int? IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
