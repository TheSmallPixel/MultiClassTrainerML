using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaTipoDannoCardDettChiu
    {
        public int IdAniaTipoDannoDettChius { get; set; }
        public int IdAniaTipoDannoCard { get; set; }
        public int? IdFlussoCard { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public string FlgTipoDannoAnia { get; set; }
        public string FlgTipoFlusso { get; set; }
        public string FlgGestionarioDebitore { get; set; }
        public DateTime? DtInvio { get; set; }
        public string IdentificativoPartita { get; set; }
        public string IdentificativoSinistro { get; set; }
        public DateTime? DtUltimoAggAnia { get; set; }
        public string FlgTipoFlussoUltimoAgg { get; set; }
        public string FlgRuoloImpresa { get; set; }
        public DateTime? DtElaborazioneAnia { get; set; }
        public string FlgTipoCaricamento { get; set; }
        public int? IdSospesoCard { get; set; }
    }
}
