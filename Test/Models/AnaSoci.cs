using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AnaSoci
    {
        public decimal KeySocio { get; set; }
        public decimal IdSocio { get; set; }
        public decimal? IdAnagrafica { get; set; }
        public decimal IdAnagraficaSocio { get; set; }
        public decimal? PerQuotaCapitale { get; set; }
        public string FlgTipoSocio { get; set; }
        public string FlgRespLegaleSino { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdUtente { get; set; }
    }
}
