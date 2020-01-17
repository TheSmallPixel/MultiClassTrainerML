using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabTestiFissi
    {
        public int IdTestoFisso { get; set; }
        public string CodiceTestoFisso { get; set; }
        public string DescrizioneTestoFisso { get; set; }
        public string TestoFissoOggetto { get; set; }
        public int? IdFormulaOggetto { get; set; }
        public string TestoFissoCorpo { get; set; }
        public int? IdFormulaCorpo { get; set; }
    }
}
