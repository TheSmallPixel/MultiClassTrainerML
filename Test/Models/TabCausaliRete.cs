using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabCausaliRete
    {
        public TabCausaliRete()
        {
            P3CodiciProd = new HashSet<P3CodiciProd>();
            RuoliReteStato = new HashSet<RuoliReteStato>();
            TabReteVenditaCodiciProd = new HashSet<TabReteVenditaCodiciProd>();
            TabReteVenditaIniziative = new HashSet<TabReteVenditaIniziative>();
            TabTipoDocumentoDossier = new HashSet<TabTipoDocumentoDossier>();
        }

        public int IdCausale { get; set; }
        public string CodCausale { get; set; }
        public int IdDescrizione { get; set; }
        public string FlgTipoCausale { get; set; }
        public string FlgTipoEntita { get; set; }
        public DateTime DtIniVal { get; set; }
        public DateTime DtFinVal { get; set; }
        public string Descrizione { get; set; }
        public string FlgCodiceStatoCausale { get; set; }

        public virtual ICollection<P3CodiciProd> P3CodiciProd { get; set; }
        public virtual ICollection<RuoliReteStato> RuoliReteStato { get; set; }
        public virtual ICollection<TabReteVenditaCodiciProd> TabReteVenditaCodiciProd { get; set; }
        public virtual ICollection<TabReteVenditaIniziative> TabReteVenditaIniziative { get; set; }
        public virtual ICollection<TabTipoDocumentoDossier> TabTipoDocumentoDossier { get; set; }
    }
}
