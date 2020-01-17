using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ScadenzeStati
    {
        public int IdScadenzaStato { get; set; }
        public int? KeyStato { get; set; }
        public int IdStato { get; set; }
        public DateTime? DtCreazione { get; set; }
        public DateTime? DtChiusura { get; set; }
        public int? IdUtenteChiusura { get; set; }
        public string FlgTipoChiusura { get; set; }
        public DateTime? DtLavorazione { get; set; }
        public int? IdUtenteLavorazione { get; set; }
        public DateTime? DtScadenza { get; set; }
        public string FlgTipologiaCruscotto { get; set; }
        public string FlgSpuntaManualeSino { get; set; }
    }
}
