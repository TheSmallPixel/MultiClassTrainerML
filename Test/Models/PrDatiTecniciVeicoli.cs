using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrDatiTecniciVeicoli
    {
        public int KeyPrDatiTecniciVeicolo { get; set; }
        public int? IdPrDatiTecniciVeicolo { get; set; }
        public int? IdPrTipoVeicolo { get; set; }
        public string FlgDatiTecniciVeicolo { get; set; }
        public string FlgFormatoVariabile { get; set; }
        public string FlgPrincipaleSino { get; set; }
        public int? ProgressivoParametro { get; set; }
        public string CodFlagSistema { get; set; }
        public string FlgObbligatorioSino { get; set; }
        public int? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
