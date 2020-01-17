using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RiepSinStatiFinali
    {
        public decimal KeyStatoFinale { get; set; }
        public decimal? IdStatoFinale { get; set; }
        public decimal? IdSinistroOrigine { get; set; }
        public decimal? IdEntitacoinvoltaOrigine { get; set; }
        public string FlgTipologiaGestione { get; set; }
        public string FlgTipoDanno { get; set; }
        public DateTime? DtRiferimento { get; set; }
        public decimal? IdStatoIniziale { get; set; }
        public string FlgDefinitivoSino { get; set; }
        public DateTime? DtStato { get; set; }
        public string FlgChiusoSsSino { get; set; }
        public string FlgChiusoSsirSino { get; set; }
        public string FlgChiusoPtSino { get; set; }
        public string FlgChiudeSinistroSino { get; set; }
        public string FlgChiudeTipoCardSino { get; set; }
        public string FlgChiudeTipoDannoSino { get; set; }
        public string FlgIndennizziSino { get; set; }
        public string FlgSpeseSino { get; set; }
        public string FlgRecuperiSino { get; set; }
        public string FlgRiservaIndennizziSino { get; set; }
        public string FlgRiservaSpeseSino { get; set; }
        public string FlgRiservaRecuperiSino { get; set; }
        public string FlgCausaSino { get; set; }
        public string FlgCausaAnnoSino { get; set; }
        public decimal? ImpIndennizzi { get; set; }
        public decimal? ImpSpese { get; set; }
        public decimal? ImpRecuperi { get; set; }
        public decimal? ImpRiservaIndennizzi { get; set; }
        public decimal? ImpRiservaSpese { get; set; }
        public decimal? ImpRiservaRecuperi { get; set; }
        public decimal? ImpRiservaCaduta { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdValuta { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal? IdCompagnia { get; set; }
        public string FlgRiservaForfaitSino { get; set; }
        public decimal? ImpRiservaForfait { get; set; }
        public string FlgTipologiaGestioneNuova { get; set; }
        public string FlgStornoSsSino { get; set; }
        public decimal? ImpRiservaCadutaForfait { get; set; }
        public decimal? ImpForfait { get; set; }
        public decimal? ImpRiservaCadutaForfaitP { get; set; }
        public decimal? ImpRiservaBilancio { get; set; }
        public decimal? ImpRiservaCadutaSpese { get; set; }
        public string FlgRiattivatoSino { get; set; }
        public DateTime? DtRiattivazione { get; set; }
        public decimal? ImpSpeseRes { get; set; }
        public decimal? ImpRiservaRes { get; set; }
        public string FlgPartitaFittiziaSino { get; set; }
    }
}
