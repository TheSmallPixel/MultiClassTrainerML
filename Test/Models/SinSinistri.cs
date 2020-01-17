using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinSinistri
    {
        public decimal KeySinistro { get; set; }
        public decimal IdSinistro { get; set; }
        public DateTime DtDenuncia { get; set; }
        public DateTime DtPervenimentoDenuncia { get; set; }
        public DateTime DtRegistrazione { get; set; }
        public decimal? IdIspettorato { get; set; }
        public DateTime DtStato { get; set; }
        public DateTime? DtInvioCoass { get; set; }
        public DateTime? DtRegistroDenunciato { get; set; }
        public decimal? IdLiquidatore { get; set; }
        public decimal IdDenunciante { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal? IdSinistrotrasporti { get; set; }
        public decimal? IdSinistrocoass { get; set; }
        public decimal? IdSinistrorca { get; set; }
        public string FlgCopertoSino { get; set; }
        public string FlgStatoSinistro { get; set; }
        public string FlgTipoCaricamento { get; set; }
        public string FlgTipoDenuncia { get; set; }
        public string FlgValidatoSino { get; set; }
        public string FlgMotivoStatoSinistro { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string NoteStato { get; set; }
        public string NSinistro { get; set; }
        public decimal AnnoEsercizio { get; set; }
        public decimal IdEvento { get; set; }
        public decimal? IdGrupposinistri { get; set; }
        public decimal IdPolizza { get; set; }
        public string FlgCatastrofaleSino { get; set; }
        public string FlgSospettoSino { get; set; }
        public string FlgAssistenzaTecnicaSino { get; set; }
        public string FlgIspezioneAmmSino { get; set; }
        public string FlgCtrlAperturaAutSino { get; set; }
        public DateTime? DtRiapertura { get; set; }
        public decimal? IdMediatorecreditizio { get; set; }
        public string FlgRamoBilancio { get; set; }
        public decimal? IdCompagnia { get; set; }
        public string FlgInibizioneStampSurrSino { get; set; }
        public decimal? IdRetevendita { get; set; }
        public string FlgForzaturaScopertoSino { get; set; }
        public string FlgSinistroAnomaloSino { get; set; }
        public int? LivelloAntiFrode { get; set; }
        public string FlgAreaSinistro { get; set; }
        public string FlgTipoLiquidazione { get; set; }
        public string FlgTipoLiquidazioneCalc { get; set; }
        public DateTime? DtIndicazioneRivalsa { get; set; }
        public string NoteIndicazioneRivalsa { get; set; }
        public string FlgSinistroElettronicoSino { get; set; }
        public string FlgFranchigiaDaRecSino { get; set; }
        public string FlgMotivoForzaturaScoperto { get; set; }
        public int? IdUtenteApertura { get; set; }
        public int? IdEventoCatastrofale { get; set; }
        public string FlgRamoTecnico { get; set; }
        public DateTime? DtForzaturaAntifrode { get; set; }
        public string FlgTipologiaSinistro { get; set; }
        public string FlgCartaceoSino { get; set; }
        public int? IdSinistroestero { get; set; }
        public string NoteDinamica { get; set; }
        public string FlgRecordAnnullatoSino { get; set; }
        public string FlgSinistroEsteroSino { get; set; }
        public string FlgTipologiaEvento { get; set; }
        public string FlgSinistroBloccatoSino { get; set; }
        public string FlgSinistroPasSino { get; set; }
        public string FlgTipoElettronicoUniqa { get; set; }
        public string FlgSistemaProvenienza { get; set; }
    }
}
