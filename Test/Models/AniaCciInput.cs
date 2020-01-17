using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaCciInput
    {
        public decimal IdAniaCciInput { get; set; }
        public DateTime? DtRicezione { get; set; }
        public decimal? Progressivo { get; set; }
        public decimal? IdCompagnia { get; set; }
        public string NomeFile { get; set; }
        public string FlgRcaInf { get; set; }
    }
}
