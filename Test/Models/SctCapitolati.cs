using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SctCapitolati
    {
        public SctCapitolati()
        {
            SctCapitolatiAgenzie = new HashSet<SctCapitolatiAgenzie>();
            SctDatiCapitolati = new HashSet<SctDatiCapitolati>();
        }

        public decimal IdSctCapitolato { get; set; }
        public decimal IdCompagnia { get; set; }
        public string CodCapitolato { get; set; }
        public decimal IdDescCapitolato { get; set; }
        public string FlgRateSuccessiveSino { get; set; }
        public string FlgRateFirmaSino { get; set; }
        public string FlgEmissioneSino { get; set; }
        public string FlgSostituzioneSino { get; set; }
        public string FlgAppendiceSino { get; set; }
        public decimal? IdUtente { get; set; }
        public string DescCapitolato { get; set; }
        public decimal? IdRetevendita { get; set; }
        public string FlgRateSuccessiveAutSino { get; set; }

        public virtual ICollection<SctCapitolatiAgenzie> SctCapitolatiAgenzie { get; set; }
        public virtual ICollection<SctDatiCapitolati> SctDatiCapitolati { get; set; }
    }
}
