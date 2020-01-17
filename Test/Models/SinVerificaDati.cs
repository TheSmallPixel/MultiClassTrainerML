using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinVerificaDati
    {
        public int KeySinVerificaDati { get; set; }
        public int IdSinVerificaDati { get; set; }
        public int IdSinistro { get; set; }
        public int? IdUtenteVerifica { get; set; }
        public string FlgVerificaDatiSino { get; set; }
        public DateTime? DtVerificaDati { get; set; }
        public string Note { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
    }
}
