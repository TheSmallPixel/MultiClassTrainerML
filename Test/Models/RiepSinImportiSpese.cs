using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RiepSinImportiSpese
    {
        public int KeyRiepSinImportiSpese { get; set; }
        public int IdRiepSinImportiSpese { get; set; }
        public int AnnoEsercizio { get; set; }
        public int MeseEsercizio { get; set; }
        public int AnnoAccadimento { get; set; }
        public string FlgRamoBilancio { get; set; }
        public string FlgTipoSpesa { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
        public decimal ImportoSpeseInterne { get; set; }
        public decimal ImportoSpeseEsterne { get; set; }
    }
}
