using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class BdiRilieviIgnorati
    {
        public int KeyRilievoIgnorato { get; set; }
        public int IdRilievoIgnorato { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public int? IdOggettoRilievo { get; set; }
        public string FlgTipoOggettoRilievo { get; set; }
        public string CodErroreIvass { get; set; }
        public string FlgIgnoratoSino { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
        public int? IdRilievo { get; set; }
    }
}
