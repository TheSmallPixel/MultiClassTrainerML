using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RiepSinStatiIniziali
    {
        public decimal KeyStatoIniziale { get; set; }
        public decimal? IdStatoIniziale { get; set; }
        public DateTime? DtRiferimento { get; set; }
        public string FlgDefinitivoSino { get; set; }
        public string NPolizza { get; set; }
        public string NFlotta { get; set; }
        public string FlgRamoBilancio { get; set; }
        public decimal? PercNostraQuota { get; set; }
        public string FlgTipoDelega { get; set; }
        public DateTime? DtAvvenimento { get; set; }
        public DateTime? DtDenuncia { get; set; }
        public DateTime? DtPervenimento { get; set; }
        public DateTime? DtRegistrazione { get; set; }
        public decimal? IdSinistroOrigine { get; set; }
        public string NSinistro { get; set; }
        public decimal? IdEntitacoinvoltaOrigine { get; set; }
        public string FlgTipologiaGestione { get; set; }
        public string FlgTipoDanno { get; set; }
        public string TargaTelaioAss { get; set; }
        public string TargaTelaioCtp { get; set; }
        public string CodCompagniaAniaCtp { get; set; }
        public decimal? AnnoRegistrazione { get; set; }
        public decimal? AnnoEsercizio { get; set; }
        public decimal? IdProvAccadimento { get; set; }
        public string FlgDenunciatoSino { get; set; }
        public string FlgMandatarioSino { get; set; }
        public string FlgTardivoSino { get; set; }
        public string FlgRiapertoSino { get; set; }
        public DateTime? DtRiapertura { get; set; }
        public string FlgRiservaIndennizziSino { get; set; }
        public decimal? ImpRiservaIndennizzi { get; set; }
        public string FlgRiservaSpeseSino { get; set; }
        public decimal? ImpRiservaSpese { get; set; }
        public string FlgRiservaRecuperiSino { get; set; }
        public decimal? ImpRiservaRecuperi { get; set; }
        public decimal? IdIspettorato { get; set; }
        public decimal? IdAssicurato { get; set; }
        public decimal? IdContraente { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdValuta { get; set; }
        public decimal? IdCompagnia { get; set; }
        public string FlgRiservaForfaitSino { get; set; }
        public decimal? ImpRiservaForfait { get; set; }
        public string FlgTipologiaGestioneVecchia { get; set; }
        public decimal? Conta { get; set; }
        public string FlgRiapreCardSino { get; set; }
        public decimal? IdControparte { get; set; }
        public string Contraente { get; set; }
        public DateTime? DtEffPolizza { get; set; }
        public string Settore { get; set; }
        public string Classe { get; set; }
        public string Uso { get; set; }
        public string CodProdotto { get; set; }
        public string CodSottoprodotto { get; set; }
        public string ContraenteCfPiva { get; set; }
        public string ContraenteSesso { get; set; }
        public int? IdProvEmissione { get; set; }
        public string TargaTelaioDanneggiato { get; set; }
        public string Assicurato { get; set; }
        public string Danneggiato { get; set; }
        public string FlgAssicuratoSino { get; set; }
        public DateTime? DtEffettoRiapertura { get; set; }
    }
}
