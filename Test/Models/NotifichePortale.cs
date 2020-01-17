using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class NotifichePortale
    {
        public int IdNotificheportale { get; set; }
        public string FlgPresaVisioneSino { get; set; }
        public DateTime? DataPresaVisione { get; set; }
        public int? IdUtenteVisione { get; set; }
        public string FlgTipologiaNotifica { get; set; }
        public DateTime? DataNotifica { get; set; }
        public string Note { get; set; }
        public int IdSinistro { get; set; }
        public int KeyIncarico { get; set; }
        public int IdIncarico { get; set; }
        public int IdUtente { get; set; }
        public int IdCompagnia { get; set; }
    }
}
