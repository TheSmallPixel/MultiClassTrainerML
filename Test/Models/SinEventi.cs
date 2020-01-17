using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinEventi
    {
        public decimal IdEvento { get; set; }
        public DateTime DtEvento { get; set; }
        public decimal? IdIndirizzo { get; set; }
        public string NoteEvento { get; set; }
        public decimal? IdCompagnia { get; set; }
        public string HhmmEvento { get; set; }
        public decimal? IdTipoEventoDen { get; set; }
        public DateTime? DtAccadimentoEvento { get; set; }

        public virtual TabTipiEventoDen IdTipoEventoDenNavigation { get; set; }
    }
}
