using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabConvenzioni
    {
        public TabConvenzioni()
        {
            PrProdottiConvenzioni = new HashSet<PrProdottiConvenzioni>();
            TabConvenzioniAgenzie = new HashSet<TabConvenzioniAgenzie>();
        }

        public decimal IdConvenzione { get; set; }
        public decimal IdCompagnia { get; set; }
        public string Codice { get; set; }
        public decimal IdDescrizione { get; set; }
        public decimal PctMaxSconto { get; set; }
        public decimal ImpSconto { get; set; }
        public decimal PctVarProvvAcquisto { get; set; }
        public decimal PctVarProvvIncasso { get; set; }
        public string FlgSommaScontoSino { get; set; }
        public string FlgScontoAutomaticoSino { get; set; }
        public string FlgRateSuccessiveSino { get; set; }
        public string FlgAlimentaPlafondSino { get; set; }
        public string FlgAutorizzazioneSino { get; set; }
        public string Descrizione { get; set; }
        public decimal? CodDeroga { get; set; }
        public string FlgTipoConvenzione { get; set; }
        public decimal? ImpScontoFisso { get; set; }

        public virtual TabCompagnie IdCompagniaNavigation { get; set; }
        public virtual ICollection<PrProdottiConvenzioni> PrProdottiConvenzioni { get; set; }
        public virtual ICollection<TabConvenzioniAgenzie> TabConvenzioniAgenzie { get; set; }
    }
}
