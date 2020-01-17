using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CbiIncassiRid
    {
        public int IdIncasso { get; set; }
        public int IdAllineamento { get; set; }
        public int? IdTitTitolo { get; set; }
        public int? IdTitEsito { get; set; }
        public int IdCompagnia { get; set; }
        public DateTime DtElaborazione { get; set; }
        public string FlgStato { get; set; }
        public string FlgRinvioSino { get; set; }
        public decimal? Importo { get; set; }
        public string FlgCodiceCausale { get; set; }
        public string MsgIdSepa { get; set; }
        public int? IdContocorrenteAddebito { get; set; }
        public int? IdTitRatePremio { get; set; }
    }
}
