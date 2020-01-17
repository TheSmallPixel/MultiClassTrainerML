using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrDatiTecniciUbicazioni
    {
        public int KeyPrDatiTecniciUbicazione { get; set; }
        public int? IdPrDatiTecniciUbicazione { get; set; }
        public int? IdPrDatiUbicazione { get; set; }
        public string FlgDatiTecniciUbicazione { get; set; }
        public string FlgFormatoVariabile { get; set; }
        public string CodFlagSistema { get; set; }
        public string FlgObbligatorioSino { get; set; }
        public int? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
