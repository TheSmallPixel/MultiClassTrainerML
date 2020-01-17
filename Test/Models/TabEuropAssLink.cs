using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabEuropAssLink
    {
        public int IdEuropAssLink { get; set; }
        public int IdCompagnia { get; set; }
        public string Dossier { get; set; }
        public string NSinistroIclaims { get; set; }
        public int AnnoSinistroIclaims { get; set; }
        public string RecordDenuncia { get; set; }
    }
}
