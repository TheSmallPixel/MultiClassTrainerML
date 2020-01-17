using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaSinistroCard
    {
        public int KeyAniaSinistroCard { get; set; }
        public int IdAniaSinistroCard { get; set; }
        public int? IdSinistro { get; set; }
        public string FlgGestionarioDebitore { get; set; }
        public string FlgUltimoFlussoAccettSino { get; set; }
        public string CodAniaCompInv { get; set; }
        public string CodAniaCompRic { get; set; }
        public string TargaInv { get; set; }
        public string TargaRic { get; set; }
        public DateTime? DtAvvenimento { get; set; }
        public decimal? ImportoSpeseArbitrato { get; set; }
        public decimal? ImportoRecuperiArbitrato { get; set; }
        public DateTime? DtPrimaPredisposizione { get; set; }
        public DateTime? DtPrimoInvio { get; set; }
        public DateTime? DtUltimoInvio { get; set; }
        public DateTime? DtPrimoOk { get; set; }
        public DateTime? DtUltimoOk { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
        public string FlgTipoCaricamento { get; set; }
        public DateTime? DtUltimaPredisposizione { get; set; }
        public string NSinistro { get; set; }
        public int? AnnoEsercizio { get; set; }
        public DateTime? DtRegistrazione { get; set; }
        public decimal? ImpIndennizziAntifrode { get; set; }
        public decimal? ImportoRecuperiAntifrode { get; set; }
        public decimal? ImpFranchigiaRecuperabile { get; set; }
        public string CodIstatComune { get; set; }
        public string FlgScoreAia { get; set; }
        public int? IdAniaSinistroCardDett { get; set; }
    }
}
