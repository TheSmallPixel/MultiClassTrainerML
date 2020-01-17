using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RepFormatiReport
    {
        public decimal IdFormatoReport { get; set; }
        public string Codice { get; set; }
        public decimal IdDescrizione { get; set; }
        public string ResponseType { get; set; }
        public string Icona { get; set; }
        public string FlgAttivaMenuBrowserSino { get; set; }
        public string Descrizione { get; set; }
    }
}
