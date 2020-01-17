using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinGarPrestazioniInf
    {
        public int KeyGarprestazioniinf { get; set; }
        public int IdGarprestazioniinf { get; set; }
        public int? IdGaranziacolpita { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public string FlgPrestazioniInfTipo { get; set; }
        public string FlgPrestazioniInfValore { get; set; }
        public int? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
