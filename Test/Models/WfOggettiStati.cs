using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class WfOggettiStati
    {
        public decimal IdOggettiStati { get; set; }
        public string FlgTipoOggetto { get; set; }
        public string FlgTipoStato { get; set; }
        public string FlgUtlimoStatoSino { get; set; }
        public string UrlIconaPerMonitor { get; set; }
        public decimal? IdDescrizione { get; set; }
        public string Descrizione { get; set; }
    }
}
