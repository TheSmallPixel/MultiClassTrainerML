using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CommaCheckinRichieste
    {
        public int IdCommaCheckinRichiesta { get; set; }
        public DateTime DtRichiesta { get; set; }
        public int IdAnagrafica { get; set; }
        public string FlgTipoAnagrafica { get; set; }
        public string CognomeRagioneSociale { get; set; }
        public string CodiceFiscale { get; set; }
    }
}
