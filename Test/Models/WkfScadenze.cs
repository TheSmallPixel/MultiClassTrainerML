using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class WkfScadenze
    {
        public int IdScadenza { get; set; }
        public int? IdCompagnia { get; set; }
        public string FlgTipoAlert { get; set; }
        public string FlgTipoOggetto { get; set; }
        public string FlgTipoStato { get; set; }
        public int GiorniMaxDisponibili { get; set; }
        public int GiorniPreAlert { get; set; }
    }
}
