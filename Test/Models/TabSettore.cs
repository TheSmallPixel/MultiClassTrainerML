using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabSettore
    {
        public TabSettore()
        {
            PrSettoriTariffari = new HashSet<PrSettoriTariffari>();
            PrTipoVeicoli = new HashSet<PrTipoVeicoli>();
            TabClasse = new HashSet<TabClasse>();
        }

        public decimal IdSettore { get; set; }
        public string CodSettore { get; set; }
        public decimal? IdDescSettore { get; set; }
        public string DescSettore { get; set; }
        public string FlgPreventivoSino { get; set; }

        public virtual ICollection<PrSettoriTariffari> PrSettoriTariffari { get; set; }
        public virtual ICollection<PrTipoVeicoli> PrTipoVeicoli { get; set; }
        public virtual ICollection<TabClasse> TabClasse { get; set; }
    }
}
