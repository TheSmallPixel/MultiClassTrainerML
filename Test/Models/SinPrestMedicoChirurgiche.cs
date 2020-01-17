using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinPrestMedicoChirurgiche
    {
        public int KeyPrestMedChir { get; set; }
        public int IdPrestMedChir { get; set; }
        public int IdMalattiatrattamento { get; set; }
        public int IdSinistro { get; set; }
        public int IdEntitacoinvolta { get; set; }
        public int IdPrestazione { get; set; }
        public decimal? Percentuale { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
    }
}
