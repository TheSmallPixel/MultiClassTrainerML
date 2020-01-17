using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaFidejIntegr
    {
        public decimal KeyFidejIntegrativa { get; set; }
        public decimal IdFidejIntegrativa { get; set; }
        public decimal IdRetevendita { get; set; }
        public string CodGestione { get; set; }
        public decimal IdCompagnia { get; set; }
        public string FlgTipoFidejIntegrativa { get; set; }
        public string EnteRilasciante { get; set; }
        public decimal ImpFidejussione { get; set; }
        public DateTime DtEffetto { get; set; }
        public DateTime DtScadenza { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal IdUtente { get; set; }
        public decimal? IdAltraCompagniaCopertura { get; set; }
    }
}
