﻿using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinEntitaSchedaDannoMorte
    {
        public int KeyEntitaschedadannomorte { get; set; }
        public int IdEntitaschedadannomorte { get; set; }
        public int IdEntitaschedalesioni { get; set; }
        public int IdEntitacoinvolta { get; set; }
        public int IdSinistro { get; set; }
        public string FlgTipoRelazioneParentela { get; set; }
        public decimal ImpDanno { get; set; }
        public decimal? ImpPersona { get; set; }
        public int? AventiDiritto { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? ImpDannoParte { get; set; }
    }
}
