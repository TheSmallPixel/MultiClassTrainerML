using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolDatiTecniciUbicazioni
    {
        public int KeyPolDatiTecniciUbi { get; set; }
        public int? IdPolDatiTecniciUbi { get; set; }
        public int? IdPolUbicazione { get; set; }
        public decimal? IdPolizza { get; set; }
        public string FlgDatiTecniciUbicazione { get; set; }
        public string CodFlagSistema { get; set; }
        public decimal? ValoreNumerico { get; set; }
        public string ValoreStringa { get; set; }
        public DateTime? ValoreData { get; set; }
        public string FlgPrincipaleSino { get; set; }
        public string FlgFormatoVariabile { get; set; }
        public int? IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
