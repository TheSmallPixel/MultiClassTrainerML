using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaSurrogheInpsErr
    {
        public int KeyAniaSurrogaInpsErr { get; set; }
        public int IdAniaSurrogaInpsErr { get; set; }
        public int IdAniaSurrogaInps { get; set; }
        public string DescErrore { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
    }
}
