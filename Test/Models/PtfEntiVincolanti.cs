using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PtfEntiVincolanti
    {
        public decimal KeyEntevincolante { get; set; }
        public decimal? IdEntevincolante { get; set; }
        public DateTime? DtEffettoVincolo { get; set; }
        public DateTime? DtScadenzaVincolo { get; set; }
        public decimal? IdAnagrafica { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdBene { get; set; }
    }
}
