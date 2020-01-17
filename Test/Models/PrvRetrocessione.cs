using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrvRetrocessione
    {
        public decimal KeyPrvRetrocessione { get; set; }
        public decimal? IdPrvRetrocessione { get; set; }
        public decimal? IdRetevendita { get; set; }
        public decimal? IdRamo { get; set; }
        public decimal? IdProdotto { get; set; }
        public string FlgTipoRetrocessione { get; set; }
        public decimal? PctRetrocessione { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdCompagnia { get; set; }
    }
}
