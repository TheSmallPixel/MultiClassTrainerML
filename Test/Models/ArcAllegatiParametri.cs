using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcAllegatiParametri
    {
        public int IdAllegatoParametro { get; set; }
        public int? IdAllegato { get; set; }
        public int? IdParametroStampa { get; set; }
        public int? IdDestinatarioPrincipale { get; set; }
        public string DtCreazione { get; set; }
        public string FlgAnnullatoSino { get; set; }
    }
}
