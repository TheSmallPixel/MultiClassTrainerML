using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcMail
    {
        public int IdArcMail { get; set; }
        public string MittenteMail { get; set; }
        public string OggettoMail { get; set; }
        public string CorpoMail { get; set; }
        public int? IdOggetto { get; set; }
        public string FlgTipoOggetto { get; set; }
        public int? IdUtente { get; set; }
        public DateTime? DtInvioMail { get; set; }
        public string FlgPecSino { get; set; }
    }
}
