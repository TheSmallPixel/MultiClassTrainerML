using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcSoggettiAntiFrode
    {
        public int KeySoggettoAntiFrode { get; set; }
        public int IdSoggettoAntiFrode { get; set; }
        public string CodiceFiscale { get; set; }
        public string PartitaIva { get; set; }
        public int LivelloAntiFrode { get; set; }
        public string Note { get; set; }
        public DateTime DtEffetto { get; set; }
        public DateTime DtScadenza { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
    }
}
