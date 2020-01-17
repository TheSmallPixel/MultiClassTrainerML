using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolVincoli
    {
        public decimal KeyPolVincolo { get; set; }
        public decimal? IdPolVincolo { get; set; }
        public decimal? IdPolizza { get; set; }
        public decimal? IdPolBene { get; set; }
        public string FlgTipoVincolo { get; set; }
        public DateTime? DtVincolo { get; set; }
        public DateTime? DtSvincolo { get; set; }
        public string NrPratica { get; set; }
        public decimal? IdAnagrafica { get; set; }
        public DateTime? DtScadVincolo { get; set; }
        public decimal IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdAllegato { get; set; }
        public string NoteAllegato { get; set; }
        public string FlgTestoLiberoSino { get; set; }
        public string FlgTestoStandardSino { get; set; }
        public decimal? IdPrVincolataria { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
