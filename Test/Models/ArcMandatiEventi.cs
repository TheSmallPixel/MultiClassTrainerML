using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcMandatiEventi
    {
        public decimal IdArcMandatiEventi { get; set; }
        public DateTime DtEvento { get; set; }
        public string FlgTipoEvento { get; set; }
        public decimal IdCompagnia { get; set; }
        public decimal? IdArcMandatoAlboAgenti { get; set; }
    }
}
