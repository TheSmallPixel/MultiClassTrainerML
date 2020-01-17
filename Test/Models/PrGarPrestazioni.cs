using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrGarPrestazioni
    {
        public int KeyPrGarPrestazioni { get; set; }
        public int IdPrGarPrestazioni { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdPrGarTariffa { get; set; }
        public int? IdPrValParametro { get; set; }
        public string CodPrestazione { get; set; }
        public int? IdDescrizione { get; set; }
        public string Descrizione { get; set; }
        public string FlgTipoIndennizzo { get; set; }
        public string FlgCreaIncaricoSino { get; set; }
        public string FlgBloccaPagRisSchedaSino { get; set; }
        public decimal? ImpMassimale { get; set; }
        public decimal? ImpFranchigia { get; set; }
        public decimal? PercScoperto { get; set; }
        public string FlgTipoMassimalizzazione { get; set; }
        public string FlgTipologiaEvento { get; set; }
        public string FlgTipologiaDanno { get; set; }
    }
}
