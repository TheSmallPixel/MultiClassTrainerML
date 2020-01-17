using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolBeni
    {
        public decimal KeyPolBene { get; set; }
        public decimal? IdPolBene { get; set; }
        public decimal IdPolizza { get; set; }
        public string FlgTipoBene { get; set; }
        public decimal? IdPolAssicurato { get; set; }
        public decimal? IdPolUbicazione { get; set; }
        public decimal? IdPolVeicolo { get; set; }
        public string Note { get; set; }
        public decimal? PrgApplicazione { get; set; }
        public string FlgInclusioneSino { get; set; }
        public decimal? IdPrCombinazione { get; set; }
        public decimal IdUtente { get; set; }
        public DateTime? DtInclusione { get; set; }
        public DateTime? DtEsclusione { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string NumeroCertificato { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
