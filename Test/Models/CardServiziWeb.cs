using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CardServiziWeb
    {
        public int IdCardServizioWeb { get; set; }
        public int IdTipoOggettoCard { get; set; }
        public int IdSinistro { get; set; }
        public int IdOggettoPadre { get; set; }
        public string FlgTipoOggettoPadre { get; set; }
        public string FlgRuoloImpresaAnia { get; set; }
        public DateTime DtCreazione { get; set; }
        public int IdStatoAttuale { get; set; }
        public DateTime DtStatoAttuale { get; set; }
    }
}
