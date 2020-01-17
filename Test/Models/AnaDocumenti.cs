using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AnaDocumenti
    {
        public decimal KeyDocumento { get; set; }
        public decimal IdDocumento { get; set; }
        public string FlgTipoDocumento { get; set; }
        public DateTime? DtRilascio { get; set; }
        public string Note { get; set; }
        public decimal? IdAnagraficaRil { get; set; }
        public DateTime? DtScadenza { get; set; }
        public string NumeroDocumento { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal? IdAnagrafica { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
