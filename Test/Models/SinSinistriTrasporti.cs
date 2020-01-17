using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinSinistriTrasporti
    {
        public decimal KeySinistrotrasporti { get; set; }
        public decimal IdMerce { get; set; }
        public string NoteAutocarro { get; set; }
        public decimal? IdIndirizzo { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal IdSinistrotrasporti { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }

        public virtual TabMerci IdMerceNavigation { get; set; }
    }
}
