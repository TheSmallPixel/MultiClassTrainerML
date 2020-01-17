using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinPianiRecupero
    {
        public int KeySinPianiRecupero { get; set; }
        public int IdSinPianiRecupero { get; set; }
        public int IdEntitacoinvolta { get; set; }
        public int IdFiduciario { get; set; }
        public DateTime DtInserimento { get; set; }
        public DateTime DtAccordo { get; set; }
        public DateTime DtInizioPiano { get; set; }
        public string ComposizioneRate { get; set; }
        public string FlgTitolo { get; set; }
        public string FlgMotivoScaPianoRec { get; set; }
        public int? IdUtenteIncentivazione { get; set; }
        public int? IdAnagraficaPagatore { get; set; }
        public decimal? ImpCaricato { get; set; }
        public decimal? ImpScaricato { get; set; }
        public decimal? ImpSpeseCaricato { get; set; }
        public decimal? ImpSpeseScaricato { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
        public DateTime? DtScarico { get; set; }
    }
}
