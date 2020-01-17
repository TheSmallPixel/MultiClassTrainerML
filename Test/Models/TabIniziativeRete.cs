using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabIniziativeRete
    {
        public TabIniziativeRete()
        {
            TabReteVenditaIniziative = new HashSet<TabReteVenditaIniziative>();
        }

        public int IdIniziativaRete { get; set; }
        public string CodIniziativa { get; set; }
        public int IdDescrizione { get; set; }
        public string FlgTipoVenditore { get; set; }
        public DateTime DtIniVal { get; set; }
        public DateTime DtFinVal { get; set; }
        public string Descrizione { get; set; }
        public int? IdModelloIniziativa { get; set; }
        public int? IdModelloIniziativaSpec { get; set; }
        public int? IdModelloIniziativaStage { get; set; }
        public int? IdAllegato { get; set; }

        public virtual ICollection<TabReteVenditaIniziative> TabReteVenditaIniziative { get; set; }
    }
}
