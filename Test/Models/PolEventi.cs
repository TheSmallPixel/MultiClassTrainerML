using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolEventi
    {
        public PolEventi()
        {
            RegTitoli = new HashSet<RegTitoli>();
            TitTitoli = new HashSet<TitTitoli>();
        }

        public decimal KeyPolEvento { get; set; }
        public decimal IdPolizza { get; set; }
        public DateTime? DtEffettoEvento { get; set; }
        public string HhmmEffetto { get; set; }
        public string FlgTipoEvento { get; set; }
        public string FlgTipoCaricamento { get; set; }
        public decimal IdUtente { get; set; }
        public string Versione { get; set; }
        public DateTime? CompetenzaEmesso { get; set; }
        public string DtSysEvento { get; set; }
        public decimal? KeyPolEventoCollegato { get; set; }
        public string FlgDocStampatoSino { get; set; }
        public decimal? IdTabMotivoStorno { get; set; }
        public decimal? KeyPolEventoProvvisorio { get; set; }
        public string DtSysRiemissione { get; set; }
        public string FlgSistemaProvenienza { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
        public virtual ICollection<RegTitoli> RegTitoli { get; set; }
        public virtual ICollection<TitTitoli> TitTitoli { get; set; }
    }
}
