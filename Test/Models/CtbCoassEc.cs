using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CtbCoassEc
    {
        public decimal KeyEcdelegaaltrui { get; set; }
        public decimal IdEcdelegaaltrui { get; set; }
        public DateTime? DtOrdinePagamento { get; set; }
        public DateTime DtRicevimentoEc { get; set; }
        public DateTime? DtPagamento { get; set; }
        public string NAssegno { get; set; }
        public decimal? IdContocorrente { get; set; }
        public decimal? IdUtente { get; set; }
        public string FlgMezzoPagamento { get; set; }
        public string FlgMotivoStorno { get; set; }
        public string FlgStatoContabile { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal IdCompagniaDelegataria { get; set; }
        public decimal AnnoEc { get; set; }
        public string NEc { get; set; }
        public decimal? IdCompagnia { get; set; }
    }
}
