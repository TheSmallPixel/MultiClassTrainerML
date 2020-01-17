using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinEntitaSchedaInfDati
    {
        public int KeyEntitaschedainfdati { get; set; }
        public int IdEntitaschedainfdati { get; set; }
        public int IdEntitaschedainfgar { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public int? IndiceCampo { get; set; }
        public decimal? PctCampo { get; set; }
        public decimal? ImpSommaAss { get; set; }
        public decimal? ImpCampo { get; set; }
        public int? NGiorni { get; set; }
        public decimal? ImpDanno { get; set; }
        public decimal? PctCampoParte { get; set; }
        public decimal? ImpSommaAssParte { get; set; }
        public decimal? ImpCampoParte { get; set; }
        public int? NGiorniParte { get; set; }
        public decimal? ImpDannoParte { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
