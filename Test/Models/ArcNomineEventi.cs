using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcNomineEventi
    {
        public decimal IdArcNomineEventi { get; set; }
        public DateTime DtEvento { get; set; }
        public string FlgTipoEvento { get; set; }
        public decimal? IdArcNominaAlboAgenti { get; set; }
    }
}
