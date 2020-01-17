using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class MfCausali
    {
        public MfCausali()
        {
            MfDati = new HashSet<MfDati>();
        }

        public decimal IdMfCausale { get; set; }
        public decimal IdCompagnia { get; set; }
        public string CodCausale { get; set; }
        public decimal IdDescCausale { get; set; }
        public string DescCausale { get; set; }
        public string FlgRichiediCcSino { get; set; }
        public string FlgSegno { get; set; }

        public virtual ICollection<MfDati> MfDati { get; set; }
    }
}
