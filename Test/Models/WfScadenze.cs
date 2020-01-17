using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class WfScadenze
    {
        public decimal IdScadenza { get; set; }
        public decimal? IdCompagnia { get; set; }
        public string FlgTipoAlert { get; set; }
        public string FlgTipoOggetto { get; set; }
        public string FlgTipoStato { get; set; }
        public decimal GiorniMaxDisponibili { get; set; }
        public decimal GiorniPreAlert { get; set; }
    }
}
