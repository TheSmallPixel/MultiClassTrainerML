using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolDestinatariRichieste
    {
        public decimal KeyPolDestinatarioRichiesta { get; set; }
        public decimal IdUtente { get; set; }
        public DateTime? DtInvioEmail { get; set; }
        public decimal IdPolAutorizzazione { get; set; }
        public decimal IdUtenteMittente { get; set; }
    }
}
