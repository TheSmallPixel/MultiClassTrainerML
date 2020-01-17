using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrvCapitolatiSpecifici
    {
        public decimal KeyPrvCapitolatoSpecifico { get; set; }
        public decimal? IdPrvCapitolatoSpecifico { get; set; }
        public decimal? IdRetevendita { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal? IdPrvCapitolato { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdRetevenditaCorr { get; set; }

        public virtual PrvCapitolati IdPrvCapitolatoNavigation { get; set; }
    }
}
