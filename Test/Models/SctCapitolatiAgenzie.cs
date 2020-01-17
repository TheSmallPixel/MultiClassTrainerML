using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SctCapitolatiAgenzie
    {
        public decimal KeySctCapitolatoAgenzia { get; set; }
        public decimal? IdSctCapitolatoAgenzia { get; set; }
        public decimal? IdCompagnia { get; set; }
        public decimal? IdRetevendita { get; set; }
        public decimal IdSctCapitolato { get; set; }
        public decimal? OrdineRicerca { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }

        public virtual SctCapitolati IdSctCapitolatoNavigation { get; set; }
    }
}
