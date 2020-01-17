using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinSottoprestMalattia
    {
        public int KeySottoprestMalattia { get; set; }
        public int IdSottoprestMalattia { get; set; }
        public int IdPrestMalattia { get; set; }
        public int IdMalattiafattura { get; set; }
        public int IdMalattiatrattamento { get; set; }
        public int IdSinistro { get; set; }
        public int IdEntitacoinvolta { get; set; }
        public int IdSottoprestazione { get; set; }
        public decimal? ImpImponibile { get; set; }
        public decimal? ImpRitAcconto { get; set; }
        public decimal? ImpIva { get; set; }
        public decimal? ImpLiquidabile { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
    }
}
