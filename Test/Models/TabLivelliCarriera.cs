using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabLivelliCarriera
    {
        public TabLivelliCarriera()
        {
            RuoliReteCarriera = new HashSet<RuoliReteCarriera>();
        }

        public int IdLivelloCarriera { get; set; }
        public string CodLivelloCarriera { get; set; }
        public int IdDescrizione { get; set; }
        public int? MesiOsservazione { get; set; }
        public string FlgTipoVenditore { get; set; }
        public DateTime DtIniVal { get; set; }
        public DateTime DtFinVal { get; set; }
        public string Descrizione { get; set; }
        public string FlgQualificaLivCarriera { get; set; }

        public virtual ICollection<RuoliReteCarriera> RuoliReteCarriera { get; set; }
    }
}
