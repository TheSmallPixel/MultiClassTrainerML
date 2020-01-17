using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RepCarteIntestate
    {
        public decimal IdCartaIntestata { get; set; }
        public DateTime DtInizioValidita { get; set; }
        public DateTime DtFineValidita { get; set; }
        public decimal IdCompagnia { get; set; }
        public string NomeFileImmTestata { get; set; }
        public string NomeFileImmPiepagina { get; set; }
        public string Note { get; set; }
    }
}
