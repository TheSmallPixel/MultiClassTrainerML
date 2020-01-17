using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolDatiTecniciVeicoli
    {
        public decimal KeyPolDatiTecniciVeicolo { get; set; }
        public decimal? IdPolDatiTecniciVeicolo { get; set; }
        public decimal? IdPolVeicolo { get; set; }
        public decimal? IdPolizza { get; set; }
        public string FlgDatiTecniciVeicolo { get; set; }
        public string CodFlagSistema { get; set; }
        public decimal? ValoreNumerico { get; set; }
        public string ValoreStringa { get; set; }
        public DateTime? ValoreData { get; set; }
        public string FlgPrincipaleSino { get; set; }
        public decimal? ProgressivoParametro { get; set; }
        public decimal? IdUtente { get; set; }
        public string FlgFormatoVariabile { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
