using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabPubblicaAnagrafiche
    {
        public decimal IdPubblicaAnagrafica { get; set; }
        public decimal IdVisibilitaAnagrafica { get; set; }
        public decimal IdRuolo { get; set; }

        public virtual TabRuoli IdRuoloNavigation { get; set; }
        public virtual TabVisibilitaAnagrafica IdVisibilitaAnagraficaNavigation { get; set; }
    }
}
