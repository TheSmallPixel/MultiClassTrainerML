using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabAnnullamentoRami
    {
        public decimal KeyTabAnnullamentoRamo { get; set; }
        public decimal? IdTabAnnullamentoRamo { get; set; }
        public decimal? IdPrRamo { get; set; }
        public decimal? IdTabMotivoStorno { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
