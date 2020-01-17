using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ScaScarichi
    {
        public ScaScarichi()
        {
            ScaDettScarichi = new HashSet<ScaDettScarichi>();
        }

        public decimal IdScarico { get; set; }
        public string NoteScarico { get; set; }
        public DateTime DtScarico { get; set; }
        public decimal IdCompagnia { get; set; }
        public decimal? IdUtente { get; set; }
        public string FlgStatoScarico { get; set; }
        public string FlgTipoEntitaScaricata { get; set; }
        public string FlgTipoScarico { get; set; }
        public DateTime DtScaricoAl { get; set; }
        public DateTime DtScaricoDal { get; set; }
        public decimal? NumeroElementi { get; set; }
        public string FlgAreaPremiSino { get; set; }
        public string FlgAreaSinistriSino { get; set; }

        public virtual ICollection<ScaDettScarichi> ScaDettScarichi { get; set; }
    }
}
