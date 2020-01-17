using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcEstrazAlboAgenti
    {
        public decimal IdArcEstrazAlboAgenti { get; set; }
        public decimal IdCompagnia { get; set; }
        public DateTime DtEstrazione { get; set; }
        public decimal? NumMandatiConferiti { get; set; }
        public decimal? NumMandatiCessati { get; set; }
        public decimal? NumMandatiVariati { get; set; }
        public decimal? NumCoagentiNominati { get; set; }
        public decimal? NumCoagentiRevocati { get; set; }
        public string FlgInviataIsvapSino { get; set; }

        public virtual TabCompagnie IdCompagniaNavigation { get; set; }
    }
}
