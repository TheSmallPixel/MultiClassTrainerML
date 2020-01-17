using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CardFunzioniSinistro
    {
        public int IdFunzioneSinistro { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdOggettoPadre { get; set; }
        public string FlgTipoOggettoPadre { get; set; }
        public int? IdTipoOggettoCard { get; set; }
        public string FlgRuoloGestionaria { get; set; }
        public string FlgRuoloRichiesta { get; set; }
        public DateTime? DtCreazione { get; set; }
        public int? IdStatoCard { get; set; }
        public DateTime? DtStatoAttuale { get; set; }
        public DateTime? DtScadenzaStato { get; set; }
        public int? IdCinquinaCard { get; set; }
        public DateTime? DtUploadDocumentiComp { get; set; }
        public DateTime? DtUploadDocumentiCtp { get; set; }
        public string FlgStatoFinaleSino { get; set; }
    }
}
