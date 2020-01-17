using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabTipiIncentivi
    {
        public int IdTipoIncentivo { get; set; }
        public string FlgTipologiaIncentivo { get; set; }
        public string Descrizione { get; set; }
        public string FlgMacroTipologiaIncentivo { get; set; }
        public DateTime DtInizioValidita { get; set; }
        public DateTime DtFineValidita { get; set; }
    }
}
