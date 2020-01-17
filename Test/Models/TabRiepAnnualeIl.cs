using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabRiepAnnualeIl
    {
        public int IdTabRiepAnnualeIl { get; set; }
        public int? IdRegione { get; set; }
        public int? AnnoRiferimento { get; set; }
        public decimal? PctInterventoLegale { get; set; }
    }
}
