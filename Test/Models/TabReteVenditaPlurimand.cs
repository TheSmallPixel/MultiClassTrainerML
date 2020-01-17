using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaPlurimand
    {
        public decimal KeyPlurimandato { get; set; }
        public decimal IdPlurimandato { get; set; }
        public decimal IdRetevendita { get; set; }
        public decimal IdCompagnia { get; set; }
        public decimal IdUtente { get; set; }
        public DateTime? DtComEffettoRapp { get; set; }
        public DateTime? DtComChiusuraRapp { get; set; }
        public DateTime? DtComunucazione { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string Note { get; set; }
        public string CodGestione { get; set; }
        public string FlgTipoCompagnia { get; set; }
    }
}
