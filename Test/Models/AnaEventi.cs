using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AnaEventi
    {
        public decimal KeyAnaEvento { get; set; }
        public decimal IdAnagrafica { get; set; }
        public DateTime DtEffettoEvento { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime DtSysEvento { get; set; }
        public string FlgTipoCaricamento { get; set; }
        public decimal? CodiceModifica { get; set; }
    }
}
