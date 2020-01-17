using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ScadenzeVisionateUtenti
    {
        public int IdScadenzaVisionataUtente { get; set; }
        public int IdScadenzaStato { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtPresaVisione { get; set; }
        public DateTime? DtAnnullamento { get; set; }
    }
}
