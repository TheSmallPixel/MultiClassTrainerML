using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabGuidaAxa
    {
        public int IdTabGuidaAxa { get; set; }
        public string FlgSpecialRulesNodo { get; set; }
        public string FlgSpecialRulesEntity { get; set; }
        public int? IdNodo { get; set; }
        public string FlgElaboratoSino { get; set; }
        public string FlgTipoInterfaccia { get; set; }
        public DateTime DtSysAggiornamento { get; set; }
        public DateTime? DtSysElaborazione { get; set; }
        public string Note { get; set; }
        public int? IdTabTrackingAxa { get; set; }
        public int? IdUtente { get; set; }
    }
}
