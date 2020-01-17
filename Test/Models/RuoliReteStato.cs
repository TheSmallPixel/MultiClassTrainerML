using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RuoliReteStato
    {
        public int IdRuoloReteStato { get; set; }
        public int IdRuoloRete { get; set; }
        public int IdTipoStatoRuoli { get; set; }
        public int IdCausale { get; set; }
        public DateTime DtDal { get; set; }
        public DateTime DtAl { get; set; }
        public string Note { get; set; }

        public virtual TabCausaliRete IdCausaleNavigation { get; set; }
        public virtual TabTipiStatiRuoli IdTipoStatoRuoliNavigation { get; set; }
    }
}
