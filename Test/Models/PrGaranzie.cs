using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrGaranzie
    {
        public decimal KeyPrGaranzia { get; set; }
        public decimal? IdPrGaranzia { get; set; }
        public decimal? IdPrSezione { get; set; }
        public decimal? IdUtente { get; set; }
        public string CodGaranzia { get; set; }
        public decimal? IdDescGaranzia { get; set; }
        public decimal? ImpPremioMin { get; set; }
        public string FlgRinnovabileSino { get; set; }
        public string FlgPacchettoSino { get; set; }
        public string FlgTipoPreselezioneGaranzia { get; set; }
        public string FlgAccessoriSino { get; set; }
        public string FlgScontabileSino { get; set; }
        public string FlgRiservataSino { get; set; }
        public string FlgNoteSino { get; set; }
        public string FlgRinnovo { get; set; }
        public string FlgSostScadenza { get; set; }
        public string FlgSostIncorso { get; set; }
        public string FlgAppendiceScadenza { get; set; }
        public string FlgAppendiceIncorso { get; set; }
        public decimal? Ordine { get; set; }
        public string FlgRimborsabileAnnSino { get; set; }
        public string FlgRimborsabileSostSino { get; set; }
        public string FlgRimborsabileAppSino { get; set; }
        public string FlgRivalutabileSino { get; set; }
        public string FlgArrotondamentoSino { get; set; }
        public decimal? IdTabFondo { get; set; }
        public string FlgPlafondSino { get; set; }
        public string FlgRimborsabileManSino { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgRichiestaCoinvolto { get; set; }
        public string FlgRiservaPremiSino { get; set; }
        public string DescGaranzia { get; set; }
        public string FlgTentataVenditaSino { get; set; }
        public DateTime? DtIniTv { get; set; }
        public DateTime? DtFinTv { get; set; }
        public string FlgSelAperturaSxSino { get; set; }
        public string FlgGarDirittiSino { get; set; }
        public string FlgRegPremioSino { get; set; }
        public string FlgTipoScomposizione { get; set; }
        public string FlgDerogaPremioSino { get; set; }
        public decimal? CodDerogaPremio { get; set; }
        public string FlgDerogaRiservataSino { get; set; }
        public decimal? CodDerogaRiservata { get; set; }
        public string FlgIndennitaRimborso { get; set; }
        public string FlgPrestUnicaRicorrente { get; set; }
        public decimal? LivelloAutorAnnullamento { get; set; }
        public string FlgTpAbilGarPreventivo { get; set; }
        public string FlgCreaGarDirAnnSino { get; set; }
        public string FlgRimborsabileEsclSino { get; set; }
        public string FlgDerogaNoteSino { get; set; }
        public int? CodLivDerogaNote { get; set; }
        public decimal? IdFormulaVendibilita { get; set; }
        public string FlgGarEsposizione { get; set; }
        public string TooltipInfo { get; set; }
    }
}
