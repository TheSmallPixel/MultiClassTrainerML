using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinDettSintesiPartite
    {
        public int KeySinDettSintesiPartite { get; set; }
        public int? IdCompagnia { get; set; }
        public DateTime? DtScarico { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdPartita { get; set; }
        public int? IdDanno { get; set; }
        public string FlgTipoGestione { get; set; }
        public string FlgTpMovimento { get; set; }
        public DateTime? DtMovimento { get; set; }
        public string ProgMovimento { get; set; }
        public string FlgStorno { get; set; }
        public string FlgChiudePartita { get; set; }
        public string FlgChiudeGestione { get; set; }
        public string FlgChiudeSinistro { get; set; }
        public string FlgCausa { get; set; }
        public decimal? ImpMovimento { get; set; }
        public string EstremiBeneficiario { get; set; }
        public string EstremiPartita { get; set; }
        public string CodCompagniaCtp { get; set; }
        public string FlgContaPezzoSino { get; set; }
        public decimal? ImpRiservaCaduta { get; set; }
        public string FlgTipoSpesa { get; set; }
        public string FlgTipoGestioneNuova { get; set; }
        public string FlgTipoGestioneOld { get; set; }
        public decimal? ImpRisEntrataIntegBil { get; set; }
        public decimal? ImpRisEntrataSpeseUlae { get; set; }
        public decimal? ImpRisCadutaBil { get; set; }
        public decimal? ImpRisCadutaBilUlae { get; set; }
        public decimal? ImpRisCadutaTecUlae { get; set; }
    }
}
