using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AiaNotificheVeic
    {
        public int KeyNotificheVeic { get; set; }
        public int IdNotificheVeic { get; set; }
        public string CodNotif { get; set; }
        public string CodUniSini { get; set; }
        public int? IdSinistro { get; set; }
        public string Targa { get; set; }
        public string CodInd { get; set; }
        public decimal? ValInd { get; set; }
        public int? IdVeicolo { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
        public int IdNotificheSin { get; set; }
    }
}
