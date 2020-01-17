using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcRegFinBrokerDett
    {
        public int IdRegFinBrokerDett { get; set; }
        public int IdRegFinBroker { get; set; }
        public int IdEsito { get; set; }
        public int IdTitTitolo { get; set; }
        public decimal? ImpLordo { get; set; }
        public decimal? ImpProvvigioni { get; set; }
        public decimal? ImpPagato { get; set; }
        public decimal? ImpPagatoProvv { get; set; }
        public decimal? ImpSaldo { get; set; }
        public string FlgTipoIncasso { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtSysRegistrazione { get; set; }
    }
}
