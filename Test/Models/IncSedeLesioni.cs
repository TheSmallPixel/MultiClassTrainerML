using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class IncSedeLesioni
    {
        public int KeyIncaricosedelesione { get; set; }
        public int IdIncaricosedelesione { get; set; }
        public int IdSinistro { get; set; }
        public int IdEntitacoinvolta { get; set; }
        public int IdIncarico { get; set; }
        public int IdIncaricodannocorporale { get; set; }
        public string FlgNaturaLesione { get; set; }
        public string FlgSedeLesione { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
