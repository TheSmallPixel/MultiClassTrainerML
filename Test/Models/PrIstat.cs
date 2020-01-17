using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrIstat
    {
        public PrIstat()
        {
            PrCoeffIstat = new HashSet<PrCoeffIstat>();
        }

        public decimal IdIstat { get; set; }
        public string CodiceIstat { get; set; }
        public decimal? IdDescrizione { get; set; }
        public string Descrizione { get; set; }

        public virtual ICollection<PrCoeffIstat> PrCoeffIstat { get; set; }
    }
}
