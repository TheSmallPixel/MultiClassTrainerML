using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Provv18Temp
    {
        public string Tipo { get; set; }
        public int? AnnoAvv { get; set; }
        public string NSinistro { get; set; }
        public int? AnnoEsercizio { get; set; }
        public int? IdSinistro { get; set; }
        public string FlgStatoSinistro { get; set; }
        public DateTime? DtStatoSin { get; set; }
        public DateTime? DtRiapSin { get; set; }
        public DateTime? DtRiapertura { get; set; }
        public string FlgStato { get; set; }
        public DateTime? DtStato { get; set; }
        public string FlgTipoVeicolo { get; set; }
        public decimal? ImpVeicoli { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public int? IdEntitacoinvoltarca { get; set; }
        public string StatoDanno { get; set; }
    }
}
