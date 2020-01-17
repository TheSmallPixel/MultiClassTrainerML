using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AiaNotificheScarti
    {
        public int KeyNotificheScarto { get; set; }
        public int IdNotificheScarto { get; set; }
        public string CodNotif { get; set; }
        public string CodSinistro { get; set; }
        public DateTime DtSegnalazione { get; set; }
        public string Causale { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdNotificheSin { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
    }
}
