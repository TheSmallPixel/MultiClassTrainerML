using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabPrestazioni
    {
        public int KeyPrestazione { get; set; }
        public int? IdPrestazione { get; set; }
        public int? IdGaranzia { get; set; }
        public string CodPrestazione { get; set; }
        public int? IdDescrizione { get; set; }
        public string Descrizione { get; set; }
        public int? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgTipoIndennizzo { get; set; }
        public string FlgCreaIncaricoSino { get; set; }
        public string FlgBloccaPagRisSchedaSino { get; set; }
        public string FlgTipologiaEvento { get; set; }
        public string FlgProntaLiquidazioneSino { get; set; }
    }
}
