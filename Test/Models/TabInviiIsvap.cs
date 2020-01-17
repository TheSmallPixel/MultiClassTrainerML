using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabInviiIsvap
    {
        public decimal IdInvio { get; set; }
        public DateTime? DtInvio { get; set; }
        public DateTime? DtPeriodoDal { get; set; }
        public DateTime? DtPeriodoAl { get; set; }
        public string FlgInviatoSino { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal? IdCompagnia { get; set; }
        public DateTime? DtEsecuzioneInvio { get; set; }
        public decimal KeyInvio { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
