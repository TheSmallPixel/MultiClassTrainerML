using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaCapTrasp
    {
        public int KeyRetevenditaCapTrasp { get; set; }
        public int IdRetevenditaCapTrasp { get; set; }
        public string FlgTipoListino { get; set; }
        public DateTime? DtInizioValidita { get; set; }
        public DateTime? DtFineValidita { get; set; }
        public int IdRetevendita { get; set; }
        public string CodGestione { get; set; }
        public int? IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
