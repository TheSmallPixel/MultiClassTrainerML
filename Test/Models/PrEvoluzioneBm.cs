using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrEvoluzioneBm
    {
        public decimal KeyPrEvoluzioneBm { get; set; }
        public decimal? IdPrEvoluzioneBm { get; set; }
        public decimal? IdUtente { get; set; }
        public string FlgSinistriRisPersSino { get; set; }
        public string FlgSinistriRisCoseSino { get; set; }
        public string FlgSinistriRisSpeseSino { get; set; }
        public string FlgSinistriPagSpeseSino { get; set; }
        public decimal? GgLimiteOsservazione { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string Codice { get; set; }
        public string Descrizione { get; set; }
        public int? IdFormula { get; set; }
        public int? IdPrParametroClasseMerito { get; set; }
        public int? IdPrParBonusProtetto { get; set; }
        public int? IdPrValParBonusProtetto { get; set; }
        public int? NumSinBonusProtetto { get; set; }
    }
}
