using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class FidiCreditoContraenti
    {
        public decimal KeyFidoContraente { get; set; }
        public decimal IdFidoContraente { get; set; }
        public decimal IdFidoAcquirente { get; set; }
        public decimal? IdAnagraficaContraente { get; set; }
        public decimal? ImpLimiteEsposizione { get; set; }
        public decimal? IdValuta { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string Note { get; set; }
        public decimal? IdUtente { get; set; }
    }
}
