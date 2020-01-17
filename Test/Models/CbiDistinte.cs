using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CbiDistinte
    {
        public CbiDistinte()
        {
            CbiDisposizioni = new HashSet<CbiDisposizioni>();
        }

        public decimal IdDistinta { get; set; }
        public decimal IdContocorrente { get; set; }
        public string FlgMezzoPagamento { get; set; }
        public decimal IdCompagnia { get; set; }
        public DateTime DtDistinta { get; set; }
        public decimal Progressivo { get; set; }
        public string FlgAutorizzataSino { get; set; }
        public DateTime? DtValuta { get; set; }
        public int? IdUtente { get; set; }
        public string FlgInviataSino { get; set; }
        public string FlgTipoDistinta { get; set; }
        public string CodRamoProdotto { get; set; }
        public string DtCreazione { get; set; }
        public string FlgStatoDistinta { get; set; }
        public DateTime? DtStatoDistinta { get; set; }

        public virtual ICollection<CbiDisposizioni> CbiDisposizioni { get; set; }
    }
}
