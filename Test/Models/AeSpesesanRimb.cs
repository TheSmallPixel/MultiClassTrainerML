using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AeSpesesanRimb
    {
        public int IdAeSpesesanRimb { get; set; }
        public string CodiceFiscaleIscritto { get; set; }
        public int AnnoCompetenza { get; set; }
        public DateTime DtElaborazione { get; set; }
        public string Rec1CodiceFiscaleSoggetto { get; set; }
        public int Rec1AnnoRiferimento { get; set; }
        public string Rec1TipologiaSpesa { get; set; }
        public int Rec1ImpSpesa { get; set; }
        public int Rec1ImpRimborso { get; set; }
    }
}
