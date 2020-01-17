using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaScaD
    {
        public int IdAniaScaD { get; set; }
        public int IdAniaScaA { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public string NomeFile { get; set; }
        public string FlgTipoDocumento { get; set; }
        public string FlgTipoFile { get; set; }
        public int? DimensioneFile { get; set; }
        public string CheckSum { get; set; }
        public int? IdAllegato { get; set; }
    }
}
