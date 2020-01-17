using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabEntiIntervenuti
    {
        public int IdTabella { get; set; }
        public int IdAnagrafica { get; set; }
        public string FlgTipoEnte { get; set; }
        public DateTime? DtInizioValidita { get; set; }
        public DateTime? DtFineValidita { get; set; }
        public int IdCompagnia { get; set; }
    }
}
