using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrGruppiClassiRischio
    {
        public int KeyPrGruppoClasseRischio { get; set; }
        public int IdPrGruppoClasseRischio { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdPrGarTariffa { get; set; }
        public int IdPrClasseRischio { get; set; }
        public decimal? ImpGruppo { get; set; }
        public decimal? CoefGruppo { get; set; }
        public decimal? PuntiGruppo { get; set; }
        public string FlgTuttiSettoriSino { get; set; }
        public string FlgAmmessoSino { get; set; }
    }
}
