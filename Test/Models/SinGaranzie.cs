using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinGaranzie
    {
        public decimal KeyGaranziacolpita { get; set; }
        public decimal? IdGaranziacolpita { get; set; }
        public decimal? IdGaranziaassicurata { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdEntitacoinvolta { get; set; }
        public int? IdMalattiatrattamento { get; set; }
        public int? IdMalattiafattura { get; set; }
        public int? IdSinistro { get; set; }
    }
}
