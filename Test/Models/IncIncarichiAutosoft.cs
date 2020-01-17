using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class IncIncarichiAutosoft
    {
        public int KeyIncaricoAutosoft { get; set; }
        public int IdIncaricoAutosoft { get; set; }
        public int IdIncarico { get; set; }
        public int IdEntitacoinvolta { get; set; }
        public int IdSinistro { get; set; }
        public DateTime? DtInvio { get; set; }
        public DateTime? DtChiusura { get; set; }
        public string FlgStato { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
