using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PregressoTfr
    {
        public string Nproposta { get; set; }
        public string Npolizza { get; set; }
        public string Npratica { get; set; }
        public string CodCompagniaIvass { get; set; }
        public decimal? Tfratc { get; set; }
        public decimal? Tfrfondo { get; set; }
        public int? IdCompagnia { get; set; }
        public int? IdPolizza { get; set; }
    }
}
