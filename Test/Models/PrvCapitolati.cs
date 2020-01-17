using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrvCapitolati
    {
        public PrvCapitolati()
        {
            PrvCapitolatiBase = new HashSet<PrvCapitolatiBase>();
            PrvCapitolatiSpecifici = new HashSet<PrvCapitolatiSpecifici>();
            PrvDatiCapitolati = new HashSet<PrvDatiCapitolati>();
        }

        public decimal IdPrvCapitolato { get; set; }
        public decimal IdCompagnia { get; set; }
        public decimal? IdRetevenditaCreazione { get; set; }
        public string CodCapitolato { get; set; }
        public decimal? IdDescCapitolato { get; set; }
        public decimal? IdUtente { get; set; }
        public string DescCapitolato { get; set; }

        public virtual ICollection<PrvCapitolatiBase> PrvCapitolatiBase { get; set; }
        public virtual ICollection<PrvCapitolatiSpecifici> PrvCapitolatiSpecifici { get; set; }
        public virtual ICollection<PrvDatiCapitolati> PrvDatiCapitolati { get; set; }
    }
}
