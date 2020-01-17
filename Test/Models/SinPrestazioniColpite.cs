using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinPrestazioniColpite
    {
        public int KeyPrestazioneColpita { get; set; }
        public int IdPrestazioneColpita { get; set; }
        public int IdGaranziacolpita { get; set; }
        public int IdPrestazione { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public int? IdDanno { get; set; }
    }
}
