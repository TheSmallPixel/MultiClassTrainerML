using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabVisibilitaAnagrafica
    {
        public TabVisibilitaAnagrafica()
        {
            TabPubblicaAnagrafiche = new HashSet<TabPubblicaAnagrafiche>();
        }

        public decimal IdVisibilitaAnagrafica { get; set; }
        public string FlgTipoRuoloUtente { get; set; }
        public decimal? IdEntitaAppartenenza { get; set; }
        public string FlgCreaPrivataSino { get; set; }
        public string FlgLeggiRiservateSino { get; set; }
        public decimal? IdUtente { get; set; }

        public virtual ICollection<TabPubblicaAnagrafiche> TabPubblicaAnagrafiche { get; set; }
    }
}
