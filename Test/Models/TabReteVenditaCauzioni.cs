using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaCauzioni
    {
        public decimal KeyCauzione { get; set; }
        public decimal IdCauzione { get; set; }
        public decimal IdRetevendita { get; set; }
        public string CodGestione { get; set; }
        public decimal IdCompagnia { get; set; }
        public string FlgTipoCauzione { get; set; }
        public decimal Importo { get; set; }
        public DateTime DtEffettoGaranzia { get; set; }
        public DateTime DtScadenzaGaranzia { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal IdUtente { get; set; }
        public string EnteRilasciante { get; set; }
        public decimal? IdAltraCompagniaCopertura { get; set; }
    }
}
