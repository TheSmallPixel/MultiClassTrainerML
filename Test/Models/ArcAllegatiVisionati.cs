using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcAllegatiVisionati
    {
        public int IdAllegatoVisionato { get; set; }
        public string IdentificativoEsterno { get; set; }
        public int? IdOggetto { get; set; }
        public string FlgTipoOggetto { get; set; }
        public string FlgVisionatoSino { get; set; }
        public int? IdAllegato { get; set; }
    }
}
