using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinEntitaSchedaLesioni
    {
        public int KeyEntitaschedalesioni { get; set; }
        public int IdEntitaschedalesioni { get; set; }
        public int IdEntitacoinvolta { get; set; }
        public int IdSinistro { get; set; }
        public DateTime DtAvvenimento { get; set; }
        public string FlgTipoTabellaLesioni { get; set; }
        public int Eta { get; set; }
        public decimal? PercDannoPermanente { get; set; }
        public decimal? PercPersPermanente { get; set; }
        public decimal? PercPersTemporaneo { get; set; }
        public decimal? ImpDannoPermanente { get; set; }
        public decimal? ImpPersPermanente { get; set; }
        public decimal? ImpPersTemporaneo { get; set; }
        public decimal? ImpSpeseMediche { get; set; }
        public decimal? ImpDanniCose { get; set; }
        public decimal? ImpRivalse { get; set; }
        public decimal? ImpOnorari { get; set; }
        public decimal? ImpAltriOneri { get; set; }
        public string Note { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? ImpDannoPatrimoniale { get; set; }
        public decimal? ImpSpeseVarieMorte { get; set; }
        public decimal? ImpSpeseFunebri { get; set; }
        public decimal? ImpRivalseMorte { get; set; }
        public int? IdEntitaschedadannoval { get; set; }
        public decimal? ImpDannoPatrimonialeParte { get; set; }
        public decimal? ImpSpeseVarieMorteParte { get; set; }
        public decimal? ImpSpeseFunebriParte { get; set; }
        public decimal? ImpRivalseMorteParte { get; set; }
        public decimal? CoeffDannoPatrimonialeIps { get; set; }
        public decimal? ImpDannoPatrimonialeIps { get; set; }
        public decimal? ImpArrotondamento { get; set; }
        public decimal? CoeffDannoPatrimIpsParte { get; set; }
        public decimal? ImpDannoPatrimIpsParte { get; set; }
        public decimal? ImpGuadagnoAnnuo { get; set; }
        public string FlgPercResponsabilitaSino { get; set; }
        public decimal? ImpMancatoGuadagno { get; set; }
        public decimal? ImpMancatoGuadagnoParte { get; set; }
        public string NoteDinamica { get; set; }
        public int? NDipendentiPolizza { get; set; }
        public int? NDipendentiAccertati { get; set; }
        public decimal? ImpRiservaProposta { get; set; }
        public string FlgOnorariPercRespSino { get; set; }
    }
}
