using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabUso
    {
        public TabUso()
        {
            PrSettoriTariffari = new HashSet<PrSettoriTariffari>();
            PrTipoVeicoli = new HashSet<PrTipoVeicoli>();
        }

        public decimal IdUso { get; set; }
        public decimal IdClasse { get; set; }
        public string CodUso { get; set; }
        public decimal? IdDescUso { get; set; }
        public string FlgVeicoloCensitoSino { get; set; }
        public string FlgQuotazioneStoricaSino { get; set; }
        public string FlgSettoreAnia { get; set; }
        public string FlgClasseAnia { get; set; }
        public string FlgUsoAnia { get; set; }
        public string FlgAttestatoSino { get; set; }
        public string FlgCartaVerdeSino { get; set; }
        public string DescUso { get; set; }
        public string FlgTipoVeicAnia { get; set; }
        public string FlgPreventivoSino { get; set; }
        public string FlgSoloTargheProvaSino { get; set; }
        public string FlgSospensioneSino { get; set; }

        public virtual TabClasse IdClasseNavigation { get; set; }
        public virtual ICollection<PrSettoriTariffari> PrSettoriTariffari { get; set; }
        public virtual ICollection<PrTipoVeicoli> PrTipoVeicoli { get; set; }
    }
}
