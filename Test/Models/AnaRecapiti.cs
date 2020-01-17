using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AnaRecapiti
    {
        public decimal KeyRecapito { get; set; }
        public decimal? IdRecapito { get; set; }
        public string Recapito { get; set; }
        public decimal? IdUtente { get; set; }
        public string FlgTipoRecapito { get; set; }
        public decimal IdAnagrafica { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
