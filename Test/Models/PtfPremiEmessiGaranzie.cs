using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PtfPremiEmessiGaranzie
    {
        public decimal IdPremioEmessoGaranzia { get; set; }
        public decimal IdPremioEmesso { get; set; }
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
        public decimal PctSsn { get; set; }
        public decimal PctTasse { get; set; }
        public decimal PctAntiracket { get; set; }
        public decimal PctFvs { get; set; }
        public decimal? ImpGarAcquisto { get; set; }
        public decimal? ImpGarIncasso { get; set; }
        public decimal? ImpAccAcquisto { get; set; }
        public decimal? ImpAccIncasso { get; set; }
        public DateTime? DtScadenzaGaranzia { get; set; }

        public virtual PtfPremiEmessi IdPremioEmessoNavigation { get; set; }
    }
}
