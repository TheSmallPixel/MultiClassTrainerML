using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TitEventi
    {
        public decimal KeyTitEvento { get; set; }
        public decimal? IdTitTitolo { get; set; }
        public DateTime? DtSysEvento { get; set; }
        public string FlgTipoEvento { get; set; }
        public string FlgTipoCaricamento { get; set; }
        public decimal IdUtente { get; set; }
        public string Versione { get; set; }
    }
}
