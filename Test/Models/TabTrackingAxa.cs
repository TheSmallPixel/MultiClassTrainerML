using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabTrackingAxa
    {
        public int IdTabTrackingAxa { get; set; }
        public string FlgTipoInterfaccia { get; set; }
        public DateTime DtSysElaborazione { get; set; }
        public string NomeFile { get; set; }
        public string Esito { get; set; }
        public string Xml { get; set; }
    }
}
