using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class StoDistinte
    {
        public int IdDistinta { get; set; }
        public int IdContocorrente { get; set; }
        public string FlgMezzoPagamento { get; set; }
        public int IdCompagnia { get; set; }
        public DateTime DtDistinta { get; set; }
        public int Progressivo { get; set; }
        public string FlgAutorizzataSino { get; set; }
        public DateTime? DtValuta { get; set; }
        public int? IdUtente { get; set; }
        public string FlgInviataSino { get; set; }
        public string FlgTipoDistinta { get; set; }
        public string CodRamoProdotto { get; set; }
        public string DtCreazione { get; set; }
        public string FlgStatoDistinta { get; set; }
        public DateTime? DtStatoDistinta { get; set; }
        public int IdStoricoUtente { get; set; }
        public string DtStorico { get; set; }
        public string FlgCancellatoSino { get; set; }
    }
}
