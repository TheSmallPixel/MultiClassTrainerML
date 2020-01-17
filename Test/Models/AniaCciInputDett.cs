using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaCciInputDett
    {
        public decimal IdAniaCciInputDett { get; set; }
        public decimal? IdAniaCciInput { get; set; }
        public decimal? IdentificativoSinistro { get; set; }
        public decimal? IdentificativoPartDanno { get; set; }
        public string IdentificativoAnomalia { get; set; }
        public string RecordRicevuto { get; set; }
        public string FlgRicomunicatoSino { get; set; }
        public string FlgCorrettoSino { get; set; }
    }
}
