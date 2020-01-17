using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AeSpesesanDett
    {
        public int IdAeSpesesanDett { get; set; }
        public int AnnoCompetenza { get; set; }
        public DateTime DtElaborazione { get; set; }
        public int Rec1TipoRecord { get; set; }
        public string Rec1CodiceFiscaleIscritto { get; set; }
        public string Rec1Filler { get; set; }
        public string Rec1CarattereControllo { get; set; }
    }
}
