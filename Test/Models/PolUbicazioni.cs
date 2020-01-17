using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolUbicazioni
    {
        public decimal KeyPolUbicazione { get; set; }
        public decimal? IdPolUbicazione { get; set; }
        public decimal? IdPolBene { get; set; }
        public decimal? IdIndirizzo { get; set; }
        public decimal? IdPolizza { get; set; }
        public decimal? AnnoCostruzione { get; set; }
        public string FlgTipoFabbricato { get; set; }
        public string FlgTipoRipartizione { get; set; }
        public string FlgAttivita { get; set; }
        public decimal IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? ValoreImmobile { get; set; }
        public string FlgAbitPrincSino { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
