using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaAltreSedi
    {
        public decimal KeyRetevenditaAltraSede { get; set; }
        public decimal IdRetevenditaAltraSede { get; set; }
        public decimal? IdIndirizzo { get; set; }
        public string NumeroTelefono { get; set; }
        public string NumeroFax { get; set; }
        public string FlgSedeSecondariaSino { get; set; }
        public string FlgPuntoRemotoSino { get; set; }
        public decimal IdRetevendita { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal IdUtente { get; set; }
        public string CodGestione { get; set; }
        public int? IdNodoSedeSec { get; set; }
    }
}
