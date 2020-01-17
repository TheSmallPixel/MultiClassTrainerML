using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class StoEventi
    {
        public int IdEvento { get; set; }
        public DateTime DtEvento { get; set; }
        public int? IdIndirizzo { get; set; }
        public string NoteEvento { get; set; }
        public int? IdCompagnia { get; set; }
        public string HhmmEvento { get; set; }
        public decimal? IdTipoEventoDen { get; set; }
        public int IdStoricoUtente { get; set; }
        public string DtStorico { get; set; }
        public string FlgCancellatoSino { get; set; }
        public DateTime? DtAccadimentoEvento { get; set; }

        public virtual TabTipiEventoDen IdTipoEventoDenNavigation { get; set; }
    }
}
