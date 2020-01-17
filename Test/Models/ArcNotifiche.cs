using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcNotifiche
    {
        public decimal IdNotifica { get; set; }
        public decimal IdCompagnia { get; set; }
        public decimal IdUtenteMittente { get; set; }
        public int? IdUtenteDestinatario { get; set; }
        public DateTime? DtNotifica { get; set; }
        public string CodErrore { get; set; }
        public string AltriDati { get; set; }
    }
}
