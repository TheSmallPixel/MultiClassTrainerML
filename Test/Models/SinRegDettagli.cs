using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinRegDettagli
    {
        public int KeySinRegDettagli { get; set; }
        public int? IdCompagnia { get; set; }
        public DateTime? DtScarico { get; set; }
        public string FlgCodTipoRegistro { get; set; }
        public string FlgComprendeUlaeSino { get; set; }
        public DateTime? DtPervenimento { get; set; }
        public int? IdSinistro { get; set; }
        public string NSinistro { get; set; }
        public DateTime? DtAccadimento { get; set; }
        public string NPolizza { get; set; }
        public string NFlotta { get; set; }
        public string EstremiContraente { get; set; }
        public string EstremiAssicurato { get; set; }
        public string EstremiPartita { get; set; }
        public string CodCompagniaCtp { get; set; }
        public string FlgRamoBilancio { get; set; }
        public string FlgTipoGestione { get; set; }
        public string FlgStorno { get; set; }
        public string FlgTipoDelega { get; set; }
        public decimal? PercNostraQuota { get; set; }
        public DateTime? DtPagamento { get; set; }
        public string EstremiBeneficiario { get; set; }
        public string FlgTpMovimento { get; set; }
        public decimal? ImpPagato { get; set; }
        public string FlgChiudePartita { get; set; }
        public string FlgChiudeGestione { get; set; }
        public string FlgChiudeSinistro { get; set; }
        public DateTime? DtChiusura { get; set; }
        public string FlgTipoGestioneNuova { get; set; }
        public decimal? ImpRiservaInd { get; set; }
        public decimal? ImpRiservaSpe { get; set; }
        public decimal? ImpRiservaRec { get; set; }
        public decimal? ImpRiservaForfait { get; set; }
        public string FlgDanniCP { get; set; }
        public string FlgCausa { get; set; }
        public DateTime? DtRiapertura { get; set; }
        public string FlgTipoGestioneOld { get; set; }
        public DateTime? DtDenuncia { get; set; }
        public DateTime? DtRegistrazione { get; set; }
        public string FlgContaPezzoSino { get; set; }
        public decimal? ImpRiservaCaduta { get; set; }
        public string FlgRiservaInizialeSino { get; set; }
        public string FlgTipoMovStampa { get; set; }
        public string CodAgenzia { get; set; }
        public string FlgTipoRiservaRegulation { get; set; }
        public DateTime? DtEffPolizza { get; set; }
        public string FlgContaPezzoFgSino { get; set; }
        public decimal? ImpRiservaSpeRes { get; set; }
        public decimal? ImpRiservaSpeLiq { get; set; }
        public decimal? ImpRiservaSpeUlae { get; set; }
    }
}
