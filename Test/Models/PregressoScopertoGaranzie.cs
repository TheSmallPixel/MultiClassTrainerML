using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PregressoScopertoGaranzie
    {
        public string CodCompagniaIvass { get; set; }
        public string NumPolizza { get; set; }
        public double? PctScoperto { get; set; }
        public int? IdCompagnia { get; set; }
        public int? IdPolizza { get; set; }
        public int? IdGaranzia { get; set; }
        public DateTime? DtProdotto { get; set; }
    }
}
