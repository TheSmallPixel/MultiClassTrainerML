using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrTassi
    {
        public decimal KeyPrTasso { get; set; }
        public decimal? IdPrTasso { get; set; }
        public decimal? IdPrGarTariffa { get; set; }
        public string ValoreParametri { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal? ImpPremioRif { get; set; }
        public decimal? TassoRif { get; set; }
        public decimal ImpFranchigiaRif { get; set; }
        public decimal PctScopertoRif { get; set; }
        public decimal ImpMaxScopertoRif { get; set; }
        public decimal ImpCapitale1Rif { get; set; }
        public decimal ImpCapitale2Rif { get; set; }
        public decimal? ImpPremioMin { get; set; }
        public decimal? TassoMin { get; set; }
        public decimal ImpFranchigiaMin { get; set; }
        public decimal PctScopertoMin { get; set; }
        public decimal ImpMaxScopertoMin { get; set; }
        public decimal ImpCapitale1Min { get; set; }
        public decimal ImpCapitale2Min { get; set; }
        public decimal ImpFranchigiaMax { get; set; }
        public decimal PctScopertoMax { get; set; }
        public decimal? ImpPremioMax { get; set; }
        public decimal? TassoMax { get; set; }
        public decimal ImpMaxScopertoMax { get; set; }
        public decimal ImpCapitale1Max { get; set; }
        public decimal ImpCapitale2Max { get; set; }
        public decimal ImpMaxSinistro { get; set; }
        public decimal ImpMaxPersone { get; set; }
        public decimal ImpMaxCose { get; set; }
        public decimal ImpMaxInterruzione { get; set; }
        public decimal NAddetti { get; set; }
        public decimal? ImpAddetto { get; set; }
        public decimal? Punti { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? NMaxAddetti { get; set; }
        public string FlgDerogaPremio { get; set; }
        public string FlgDerogaTassoSino { get; set; }
        public string FlgDerogaFranchigiaSino { get; set; }
        public string FlgDerogaScopertoSino { get; set; }
        public string FlgDerogaMaxScopertoSino { get; set; }
        public string FlgDerogaCapitale1Sino { get; set; }
        public string FlgDerogaCapitale2Sino { get; set; }
        public decimal? CodDerogaCapitale1 { get; set; }
        public decimal? CodDerogaCapitale2 { get; set; }
        public decimal? CodDerogaFranchigia { get; set; }
        public decimal? CodDerogaMaxScoperto { get; set; }
        public decimal? CodDerogaPremio { get; set; }
        public decimal? CodDerogaScoperto { get; set; }
        public decimal? CodDerogaTasso { get; set; }
        public decimal? ImpPremioLim { get; set; }
        public decimal? ImpTassoLim { get; set; }
        public decimal? ImpCapitale1Lim { get; set; }
        public decimal? ImpCapitale2Lim { get; set; }
        public decimal? ImpFranchigiaLim { get; set; }
        public decimal? PctScopertoLim { get; set; }
        public decimal? ImpMaxScopertoLim { get; set; }
    }
}
