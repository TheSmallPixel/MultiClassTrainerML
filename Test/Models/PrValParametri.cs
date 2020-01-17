using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrValParametri
    {
        public decimal KeyPrValParametro { get; set; }
        public decimal? IdPrValParametro { get; set; }
        public decimal? IdPrParametro { get; set; }
        public decimal? IdUtente { get; set; }
        public string CodValore { get; set; }
        public decimal? IdDescValore { get; set; }
        public string FlgRiservatoSino { get; set; }
        public decimal ImpFranchigia { get; set; }
        public decimal PctScoperto { get; set; }
        public decimal ImpMaxScoperto { get; set; }
        public decimal ImpCapitale1 { get; set; }
        public decimal ImpCapitale2 { get; set; }
        public decimal ImpMaxSinistro { get; set; }
        public decimal ImpMaxPersone { get; set; }
        public decimal ImpMaxCose { get; set; }
        public decimal ImpMaxInterruzione { get; set; }
        public decimal NAddetti { get; set; }
        public string FlgFranchigiaSino { get; set; }
        public string FlgPctScopertoSino { get; set; }
        public string FlgMaxScopertoSino { get; set; }
        public string FlgImpCapitale1Sino { get; set; }
        public string FlgImpCapitale2Sino { get; set; }
        public string FlgMaxSinistroSino { get; set; }
        public string FlgMaxPersoneSino { get; set; }
        public string FlgMaxCoseSino { get; set; }
        public string FlgMaxInterSino { get; set; }
        public string FlgNAddettiSino { get; set; }
        public decimal? IdPrPremioParametro { get; set; }
        public string FlgTuttiSettoriSino { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string DescValore { get; set; }
        public string FlgDerogaRiservatoSino { get; set; }
        public decimal? CodDerogaRiservato { get; set; }
        public int? IdPrGarTariffa { get; set; }
        public decimal? ImpParametro { get; set; }
        public decimal? CoefParametro { get; set; }
        public decimal? PuntiParametro { get; set; }
        public string FlgRicImpCapitale1Sino { get; set; }
        public string FlgRicImpCapitale2Sino { get; set; }
        public string FlgRicFranchigiaSino { get; set; }
        public string FlgRicMaxSinistroSino { get; set; }
        public string FlgRicMaxPersoneSino { get; set; }
        public string FlgRicMaxCoseSino { get; set; }
        public string FlgRicMaxInterSino { get; set; }
        public string FlgRicMaxScopertoSino { get; set; }
        public string FlgRicPctScopertoSino { get; set; }
        public string FlgRicNAddettiSino { get; set; }
        public string FlgRicImportoSino { get; set; }
        public string FlgRicCoeffSino { get; set; }
    }
}
