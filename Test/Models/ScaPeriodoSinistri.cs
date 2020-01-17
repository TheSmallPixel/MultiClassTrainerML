using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ScaPeriodoSinistri
    {
        public decimal IdPeriodoSinistri { get; set; }
        public decimal IdUtente { get; set; }
        public DateTime DtLimiteOperazioni { get; set; }
        public DateTime DtInizioValiditaDtLimite { get; set; }
        public DateTime DtFineValiditaDtLimite { get; set; }
        public string NoteMotivoVariazione { get; set; }
        public decimal IdCompagnia { get; set; }
    }
}
