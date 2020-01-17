using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PtfCoass
    {
        public decimal KeyCoasspolizza { get; set; }
        public decimal IdCoasspolizza { get; set; }
        public decimal IdCompagnia { get; set; }
        public decimal PerQuotaCoass { get; set; }
        public string FlgTipoCompagniaCoass { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal IdPolizza { get; set; }
    }
}
