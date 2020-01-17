using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AiaNotificheComp
    {
        public int KeyNotificheComp { get; set; }
        public int IdNotificheComp { get; set; }
        public string CodNotif { get; set; }
        public string CodUniSini { get; set; }
        public int? IdSinistro { get; set; }
        public string CodImpr { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
        public int IdNotificheSin { get; set; }
    }
}
