using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcAllegatiMotivoAss
    {
        public int IdAllegatoMotivoAss { get; set; }
        public int IdRegolaAllegato { get; set; }
        public string FlgMotivoAssicurazione { get; set; }
        public int IdUtente { get; set; }
    }
}
