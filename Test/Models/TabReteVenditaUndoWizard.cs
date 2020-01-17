using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaUndoWizard
    {
        public int IdUndowizard { get; set; }
        public int IdRetevendita { get; set; }
        public string CodGestione { get; set; }
        public int IdOggetto { get; set; }
        public string FlgTipoOggetto { get; set; }
        public int IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
    }
}
