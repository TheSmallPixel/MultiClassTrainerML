using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcDerogheEscalation
    {
        public int IdDerogaescalation { get; set; }
        public int IdDeroga { get; set; }
        public int IdUtenteRichiestaOrig { get; set; }
        public int IdUtenteRichiesta { get; set; }
        public int? IdGruppoAssegnata { get; set; }
        public int? IdUtenteAssegnata { get; set; }
    }
}
