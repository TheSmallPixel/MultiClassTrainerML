using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class EstSinistriErrElab
    {
        public decimal IdErroreElab { get; set; }
        public string DescrizioneErrore { get; set; }
        public decimal? IdEstrazione { get; set; }
        public int? IdCompagnia { get; set; }
    }
}
