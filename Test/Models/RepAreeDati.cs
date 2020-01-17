using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RepAreeDati
    {
        public decimal IdAreaDati { get; set; }
        public string Codice { get; set; }
        public string UrlXsd { get; set; }
        public decimal IdDescrizione { get; set; }
        public string Note { get; set; }
        public decimal IdLingua { get; set; }
        public string Descrizione { get; set; }
        public string FlgCartaIntestataSino { get; set; }
        public string FlgMultiindirizzoSino { get; set; }
    }
}
