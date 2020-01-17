using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class FidiCreditoAcquirenti
    {
        public decimal KeyFidoAcquirente { get; set; }
        public decimal IdFidoAcquirente { get; set; }
        public decimal IdAnagraficaAcquirente { get; set; }
        public decimal? ImportoAffidamento { get; set; }
        public string Note { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdValuta { get; set; }
        public decimal? IdUtente { get; set; }
    }
}
