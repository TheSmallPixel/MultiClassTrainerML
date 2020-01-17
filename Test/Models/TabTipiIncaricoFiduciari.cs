using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabTipiIncaricoFiduciari
    {
        public decimal IdTipoincaricofiduciario { get; set; }
        public decimal? IdFiduciario { get; set; }
        public decimal? ImpCostoMedio { get; set; }
        public decimal? IdValuta { get; set; }
        public string FlgTipoSpesa { get; set; }
        public string FlgTipoIncarico { get; set; }
        public string FlgMedicoIsvapSino { get; set; }
        public string FlgLegaleIsvapSino { get; set; }
        public string FlgRichiediValutazioneSino { get; set; }
        public string FlgCoseSino { get; set; }
        public string FlgReSino { get; set; }
        public string FlgPersSino { get; set; }
        public string FlgVeicSino { get; set; }
        public DateTime? DtInizioAccadimentoSinistro { get; set; }
        public DateTime? DtFineAccadimentoSinistro { get; set; }
        public string FlgCardDebitore2FirmeSino { get; set; }
        public string FlgScaricoAutomaticoSino { get; set; }
        public int? IdFormula { get; set; }
        public string FlgTipoPerito { get; set; }
        public string FlgAbilitaPortaleSino { get; set; }
        public string FlgFatturaFaseIncaricoSino { get; set; }
        public string DefaultReCoseSino { get; set; }
        public string DefaultLesioniSino { get; set; }
        public string DefaultVeicoliSino { get; set; }
        public string FlgRecuperoDocSino { get; set; }
        public string FlgTipoPortalePeriti { get; set; }
        public string FlgTipoSpesaFissa { get; set; }
        public string FlgMacroAreaAppartenenza { get; set; }
        public string FlgAreaAppartenenza { get; set; }
        public string FlgSpecificaAreaApp { get; set; }

        public virtual TabFiduciari IdFiduciarioNavigation { get; set; }
    }
}
