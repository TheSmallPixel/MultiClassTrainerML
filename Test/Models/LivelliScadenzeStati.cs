using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class LivelliScadenzeStati
    {
        public int IdLivelloScadenzaStato { get; set; }
        public int IdScadenzaStato { get; set; }
        public DateTime DtInizio { get; set; }
        public DateTime DtFine { get; set; }
        public int IdScadenzaStatoOggetto { get; set; }
        public int? IdOggettoTarget { get; set; }
        public string FlgTipoOggettoTarget { get; set; }
        public DateTime? DtAnnullamento { get; set; }
        public string FlgCausaleAnnullamento { get; set; }
        public int? IdTarget { get; set; }
    }
}
