using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AnaAggiuntiviFis
    {
        public decimal KeyDatiaggpersfisica { get; set; }
        public decimal IdDatiaggpersfisica { get; set; }
        public string FlgStatoCivile { get; set; }
        public string FlgTitoloStudio { get; set; }
        public string FlgProfessione { get; set; }
        public string FlgAttivita { get; set; }
        public decimal? IdNazione { get; set; }
        public decimal? ImpLordoMensile { get; set; }
        public decimal? ImpTfr { get; set; }
        public DateTime? DtAssunzione { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdAnagraficaMand { get; set; }
        public string FlgEsperienzaPrec { get; set; }
        public decimal? ImpTfrFondo { get; set; }
    }
}
