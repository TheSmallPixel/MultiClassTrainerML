using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrVincolatarie
    {
        public PrVincolatarie()
        {
            PrModelliVincolatarie = new HashSet<PrModelliVincolatarie>();
        }

        public decimal IdPrVincolataria { get; set; }
        public DateTime DtInizioValidita { get; set; }
        public DateTime DtFineValidita { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal IdAnagrafica { get; set; }

        public virtual ICollection<PrModelliVincolatarie> PrModelliVincolatarie { get; set; }
    }
}
