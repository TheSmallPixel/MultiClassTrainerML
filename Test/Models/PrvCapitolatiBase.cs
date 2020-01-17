using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrvCapitolatiBase
    {
        public decimal KeyPrvCapitolatoBase { get; set; }
        public decimal? IdPrvCapitolatoBase { get; set; }
        public decimal? IdRetevenditaSup { get; set; }
        public string FlgTipoReteVendita { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal? IdPrvCapitolato { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? Livello { get; set; }

        public virtual PrvCapitolati IdPrvCapitolatoNavigation { get; set; }
    }
}
