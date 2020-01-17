using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaCom
    {
        public decimal KeyComuneCompetenza { get; set; }
        public decimal IdComuneCompetenza { get; set; }
        public decimal IdRetevendita { get; set; }
        public decimal IdComune { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdUtente { get; set; }
    }
}
