using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcMandatiAlboAgentiAltri
    {
        public decimal KeyArcMandAlboAgentiAltri { get; set; }
        public decimal IdArcMandAlboAgentiAltri { get; set; }
        public string FlgOperativitaDanniSino { get; set; }
        public string FlgOperativitaVitaSino { get; set; }
        public decimal IdArcMandatoAlboAgenti { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal IdUtente { get; set; }
        public string FlgAdesioneMandato2012 { get; set; }
        public DateTime? DtAdesioneMandato2012 { get; set; }
        public string FlgCompenso { get; set; }
        public string FlgTipoProvvigioni { get; set; }
        public string FlgAccordoAutomazione { get; set; }
        public decimal? ImpAutomazione { get; set; }
    }
}
