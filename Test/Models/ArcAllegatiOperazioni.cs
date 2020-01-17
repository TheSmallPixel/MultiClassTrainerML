using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcAllegatiOperazioni
    {
        public int IdAllegatoOperazione { get; set; }
        public int IdRegolaAllegato { get; set; }
        public string FlgTipoEvento { get; set; }
        public int IdUtente { get; set; }
    }
}
