using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabClasse
    {
        public TabClasse()
        {
            PrSettoriTariffari = new HashSet<PrSettoriTariffari>();
            PrTipoVeicoli = new HashSet<PrTipoVeicoli>();
            TabUso = new HashSet<TabUso>();
        }

        public decimal IdClasse { get; set; }
        public decimal IdSettore { get; set; }
        public string CodClasse { get; set; }
        public decimal? IdDescClasse { get; set; }
        public string CodVeicoloAnia { get; set; }
        public string DescClasse { get; set; }
        public string FlgPreventivoSino { get; set; }

        public virtual TabSettore IdSettoreNavigation { get; set; }
        public virtual ICollection<PrSettoriTariffari> PrSettoriTariffari { get; set; }
        public virtual ICollection<PrTipoVeicoli> PrTipoVeicoli { get; set; }
        public virtual ICollection<TabUso> TabUso { get; set; }
    }
}
