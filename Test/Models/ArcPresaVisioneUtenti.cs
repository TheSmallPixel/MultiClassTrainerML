using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcPresaVisioneUtenti
    {
        public int IdPresaVisioneUtente { get; set; }
        public int? IdAllegatoVisionato { get; set; }
        public int? IdUtente { get; set; }
        public DateTime? DtPresaVisione { get; set; }
    }
}
