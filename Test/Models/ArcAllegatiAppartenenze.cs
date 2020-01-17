using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcAllegatiAppartenenze
    {
        public int IdAllegatoAppartenenze { get; set; }
        public int IdAllegato { get; set; }
        public string FlgTipoOggetto { get; set; }
        public int IdOggetto { get; set; }
        public string FlgStatoInvioDocumento { get; set; }
    }
}
