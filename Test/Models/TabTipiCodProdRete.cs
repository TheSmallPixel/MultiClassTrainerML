using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabTipiCodProdRete
    {
        public TabTipiCodProdRete()
        {
            TabReteVenditaCodiciProd = new HashSet<TabReteVenditaCodiciProd>();
        }

        public int IdTipoCodProd { get; set; }
        public string CodTipoProd { get; set; }
        public int IdDescrizione { get; set; }
        public string FlgTipoEntita { get; set; }
        public DateTime DtIniVal { get; set; }
        public DateTime DtFinVal { get; set; }
        public string Descrizione { get; set; }

        public virtual ICollection<TabReteVenditaCodiciProd> TabReteVenditaCodiciProd { get; set; }
    }
}
