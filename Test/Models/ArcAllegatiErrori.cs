using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcAllegatiErrori
    {
        public int IdAllegatoErrore { get; set; }
        public int? IdAllegato { get; set; }
        public string Descrizione { get; set; }
        public DateTime? DtErrore { get; set; }
    }
}
