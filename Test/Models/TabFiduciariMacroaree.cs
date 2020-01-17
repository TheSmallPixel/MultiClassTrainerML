using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabFiduciariMacroaree
    {
        public int KeyFiduciariMacroaree { get; set; }
        public int IdFiduciariMacroaree { get; set; }
        public string FlgMacroAreaAppartenenza { get; set; }
        public string EmailUfficio { get; set; }
        public int? IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
