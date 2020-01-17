using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CtbRiservePrestazioni
    {
        public int KeyRiservaprestazione { get; set; }
        public int IdRiservaprestazione { get; set; }
        public int IdRiserva { get; set; }
        public int IdGaranziacolpita { get; set; }
        public int IdPrestazione { get; set; }
        public decimal? Importo { get; set; }
        public int IdValuta { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? KeyRiserva { get; set; }
    }
}
