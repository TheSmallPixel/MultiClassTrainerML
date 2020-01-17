using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabTipiStatiRuoli
    {
        public TabTipiStatiRuoli()
        {
            RuoliReteStato = new HashSet<RuoliReteStato>();
        }

        public int IdTipoStatoRuoli { get; set; }
        public string CodTipoStatoRuoli { get; set; }
        public int IdDescrizione { get; set; }
        public string FlgTipoVenditore { get; set; }
        public DateTime DtIniVal { get; set; }
        public DateTime DtFinVal { get; set; }
        public string Descrizione { get; set; }

        public virtual ICollection<RuoliReteStato> RuoliReteStato { get; set; }
    }
}
