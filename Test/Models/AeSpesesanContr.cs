using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AeSpesesanContr
    {
        public int IdAeSpesesanContr { get; set; }
        public string CodiceFiscaleIscritto { get; set; }
        public int AnnoCompetenza { get; set; }
        public DateTime DtElaborazione { get; set; }
        public string Rec1CodiceFiscaleSoggetto { get; set; }
        public int Rec1ImpTotContribCorr { get; set; }
        public int Rec1ImpTotContribPrec { get; set; }
        public int? Rec1TipoContributi { get; set; }
    }
}
