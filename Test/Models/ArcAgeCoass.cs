using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcAgeCoass
    {
        public ArcAgeCoass()
        {
            PolCoass = new HashSet<PolCoass>();
        }

        public decimal IdAgeCoass { get; set; }
        public string CodAgeCoass { get; set; }
        public decimal IdRetevendita { get; set; }
        public decimal IdAnagrafica { get; set; }
        public DateTime? DtInizio { get; set; }
        public DateTime? DtFine { get; set; }

        public virtual ICollection<PolCoass> PolCoass { get; set; }
    }
}
