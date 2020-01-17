using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcPolizzeAntiFrode
    {
        public int KeyPolizzaAntiFrode { get; set; }
        public int IdPolizzaAntiFrode { get; set; }
        public int IdCompagnia { get; set; }
        public string NumeroPolizza { get; set; }
        public int LivelloAntiFrode { get; set; }
        public string Note { get; set; }
        public DateTime DtEffetto { get; set; }
        public DateTime DtScadenza { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
    }
}
