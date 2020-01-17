using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class StatGestDettaglio
    {
        public int IdStatGestDettaglio { get; set; }
        public int IdStatGestRiepilogo { get; set; }
        public string FlgValoreIndiceDanno { get; set; }
        public string NSinistro { get; set; }
        public int AnnoEsercizio { get; set; }
        public int IdSinistro { get; set; }
        public int IdPartita { get; set; }
        public string FlgTipologiaDanno { get; set; }
        public string FlgStatoGestSin { get; set; }
        public string FlgStatoGestPart { get; set; }
        public string FlgStatoGestDanno { get; set; }
        public decimal? ImpPagato { get; set; }
        public decimal? ImpRiserva { get; set; }
        public decimal? ImpRiservaInEntrata { get; set; }
        public int IdIspettoratoOrig { get; set; }
        public int IdIspettoratoUltimo { get; set; }
        public int? IdLiquidatoreOrig { get; set; }
        public int? IdLiquidatoreUltimo { get; set; }
        public string FlgTipoCoass { get; set; }
        public string FlgRamoBilancio { get; set; }
        public string FlgRamoTecnico { get; set; }
        public string FlgSinistroEsteroSino { get; set; }
        public string FlgSinistroAntifrodeSino { get; set; }
        public string FlgSinsitriAssOutsouSino { get; set; }
        public DateTime DtRegistrazione { get; set; }
        public int IdAgenzia { get; set; }
        public string FlgCardDebitoreSino { get; set; }
        public string FlgCttPassivoSino { get; set; }
        public int ProgressivoPartitaDanno { get; set; }
        public string FlgCitazioneCaricataSino { get; set; }
        public string FlgCitazioneScaricataSino { get; set; }
        public string FlgCitazionePendenteSino { get; set; }
        public string FlgCausaCaricataSino { get; set; }
        public string FlgCausaScaricataSino { get; set; }
        public string FlgCausaPendenteSino { get; set; }
        public int? GgPervenimIncPer { get; set; }
        public int? GgPervenimApertura { get; set; }
        public int? GgPervenimChiusPagTot { get; set; }
        public int? GgDenunciaApertura { get; set; }
        public int? GgDenunciaChiusPagTot { get; set; }
        public int? GgIncPerScaPer { get; set; }
        public int? GgScaPerChiusPagTot { get; set; }
        public string FlgValoreIndicePart { get; set; }
        public string FlgLdaSino { get; set; }
        public string FlgProntaLiqSino { get; set; }
        public string FlgValoreIndiceSin { get; set; }
        public int? IdIspettoratoOrigSin { get; set; }
        public int? IdIspettoratoUltimoSin { get; set; }
        public int? IdLiquidatoreOrigSin { get; set; }
        public int? IdLiquidatoreUltimoSin { get; set; }
        public string FlgElettronicoSino { get; set; }
        public string FlgEsitoCitazione { get; set; }
        public string FlgMortaleSino { get; set; }
        public string FlgTipologiaGestionePartita { get; set; }
    }
}
