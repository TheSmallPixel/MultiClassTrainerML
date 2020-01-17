using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PtfPremiIncassatiGaranzie
    {
        public decimal IdPremioIncassatoGaranzia { get; set; }
        public decimal IdPremioIncassato { get; set; }
        public decimal IdPrGaranzia { get; set; }
        public decimal IdPrGarScomposizione { get; set; }
        public string CodGaranzia { get; set; }
        public string FlgCatTariffa { get; set; }
        public string FlgRamoBilancio { get; set; }
        public decimal ImpNetto { get; set; }
        public decimal ImpAccessori { get; set; }
        public decimal ImpSsn { get; set; }
        public decimal ImpTasse { get; set; }
        public decimal ImpAntiracket { get; set; }
        public decimal ImpImponibileSoggetto { get; set; }
        public decimal ImpImponibileNonSoggetto { get; set; }
        public decimal ImpImponibileEsente { get; set; }
        public decimal PctSsn { get; set; }
        public decimal PctTasse { get; set; }
        public decimal PctAntiracket { get; set; }
        public decimal PctFvs { get; set; }
        public decimal? ImpGarAcquisto { get; set; }
        public decimal? ImpGarIncasso { get; set; }
        public decimal? ImpAccAcquisto { get; set; }
        public decimal? ImpAccIncasso { get; set; }
        public DateTime? DtScadenzaGaranzia { get; set; }
        public string ProvTasseRca { get; set; }

        public virtual PtfPremiIncassati IdPremioIncassatoNavigation { get; set; }
    }
}
