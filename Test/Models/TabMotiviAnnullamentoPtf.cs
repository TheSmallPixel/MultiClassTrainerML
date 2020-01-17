using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabMotiviAnnullamentoPtf
    {
        public int KeyMotiviAnnullamentoPtf { get; set; }
        public int IdMotiviAnnullamentoPtf { get; set; }
        public string Descrizione { get; set; }
        public string Codice { get; set; }
        public int IdCompagnia { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
        public string FlgRcaSino { get; set; }
        public string FlgReSino { get; set; }
    }
}
