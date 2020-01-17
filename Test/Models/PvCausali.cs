using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PvCausali
    {
        public PvCausali()
        {
            PvDati = new HashSet<PvDati>();
        }

        public decimal IdPvCausale { get; set; }
        public decimal? IdCompagnia { get; set; }
        public string CodCausale { get; set; }
        public decimal? IdDescCausale { get; set; }
        public string FlgTipoCausale { get; set; }
        public string FlgSegnoCausale { get; set; }
        public decimal? IdPvCausaleStorno { get; set; }
        public string DescCausale { get; set; }
        public string FlgSoggettaRitenutaSino { get; set; }
        public string FlgScaricoCogePv { get; set; }

        public virtual ICollection<PvDati> PvDati { get; set; }
    }
}
