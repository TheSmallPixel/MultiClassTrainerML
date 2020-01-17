using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrParametri
    {
        public decimal KeyPrParametro { get; set; }
        public decimal? IdPrParametro { get; set; }
        public decimal? IdPrGarTariffa { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal? ProgressivoParametro { get; set; }
        public decimal? IdDescParametro { get; set; }
        public string FlgRichiestoSino { get; set; }
        public string FlgCombinatoSino { get; set; }
        public string FlgEditabileSino { get; set; }
        public string FlgFormatoVariabile { get; set; }
        public decimal? IdPrParametroEreditato { get; set; }
        public string FlgTuttiSettoriSino { get; set; }
        public string FlgVisualizzaSino { get; set; }
        public decimal? IdDescAggiuntivaParametro { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string DescParametro { get; set; }
        public string DescAggiuntivaParametro { get; set; }
        public string FlgCalcProvvSino { get; set; }
        public string FlgTipoValorizzazione { get; set; }
        public decimal? IdFormulaPrevalorizzazione { get; set; }
        public string FlgEvolutivoSino { get; set; }
        public string FlgAbilForzaturaSino { get; set; }
        public string FlgParametroSezioneSino { get; set; }
        public int? IdFormulaAbilitazione { get; set; }
        public string FlgStampaSino { get; set; }
        public string CodValoreDefault { get; set; }
        public string TooltipInfo { get; set; }
    }
}
