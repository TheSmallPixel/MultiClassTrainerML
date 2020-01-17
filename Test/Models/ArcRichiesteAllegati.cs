using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcRichiesteAllegati
    {
        public int IdRichiesteAllegati { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdUtente { get; set; }
        public DateTime? DataRichiesta { get; set; }
        public string TipoRichiesta { get; set; }
        public string RecordInviato { get; set; }
    }
}
