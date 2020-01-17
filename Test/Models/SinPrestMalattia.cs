using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinPrestMalattia
    {
        public int KeyPrestMalattia { get; set; }
        public int IdPrestMalattia { get; set; }
        public int IdMalattiafattura { get; set; }
        public int IdMalattiatrattamento { get; set; }
        public int IdSinistro { get; set; }
        public int IdEntitacoinvolta { get; set; }
        public int? IdMalattiaLa { get; set; }
        public decimal? ImpImponibile { get; set; }
        public decimal? PercIva { get; set; }
        public decimal? ImpTotaleFattura { get; set; }
        public decimal? ImpRimborsoEnti { get; set; }
        public decimal? ImpFranchigia { get; set; }
        public decimal? PercScoperto { get; set; }
        public decimal? ImpFranchigiaScoperto { get; set; }
        public decimal? ImpLiquidabile { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
        public int? IdGaranzia { get; set; }
        public int? IdTariffa { get; set; }
        public decimal? ImpLiquidabileTeorico { get; set; }
        public int? IdPrestazione { get; set; }
        public decimal? ImpRitAcconto { get; set; }
        public decimal? ImpIva { get; set; }
    }
}
