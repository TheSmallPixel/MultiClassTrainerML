using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaEventi
    {
        public decimal KeyRetevenditaEvento { get; set; }
        public decimal IdRetevendita { get; set; }
        public DateTime DtEffettoEvento { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime DtSysEvento { get; set; }
        public string FlgTipoCaricamento { get; set; }
        public decimal? CodiceModifica { get; set; }
    }
}
