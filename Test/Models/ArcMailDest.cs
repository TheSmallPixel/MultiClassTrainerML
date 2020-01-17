using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcMailDest
    {
        public int IdArcMailDest { get; set; }
        public int IdArcMail { get; set; }
        public string FlgTipoDestinatario { get; set; }
        public int? IdUtente { get; set; }
        public string MailDestinatario { get; set; }
    }
}
