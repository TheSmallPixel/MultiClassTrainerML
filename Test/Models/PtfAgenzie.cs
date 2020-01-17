using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PtfAgenzie
    {
        public decimal KeyPolAgenzia { get; set; }
        public decimal? IdPolAgenzia { get; set; }
        public decimal IdPolizza { get; set; }
        public decimal IdRetevendita { get; set; }
        public decimal? Livello { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
