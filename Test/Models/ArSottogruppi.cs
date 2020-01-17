using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArSottogruppi
    {
        public decimal KeyArSottogruppo { get; set; }
        public decimal IdArSottogruppo { get; set; }
        public string CodiceSottogruppo { get; set; }
        public decimal IdDescrizione { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string Descrizione { get; set; }
    }
}
