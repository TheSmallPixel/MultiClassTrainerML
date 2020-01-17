using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabAppendici
    {
        public decimal KeyTabAppendice { get; set; }
        public decimal? IdTabAppendice { get; set; }
        public decimal? IdCompagnia { get; set; }
        public string CodAppendice { get; set; }
        public decimal? IdDescAppendice { get; set; }
        public string FlgAutorizzazioneSino { get; set; }
        public string FlgVariazionePtfSino { get; set; }
        public string FlgEmissioneRetroattivaSino { get; set; }
        public string FlgPremioSino { get; set; }
        public string FlgGeneraTitoloZeroSino { get; set; }
        public string FlgIncassoTitoloZeroSino { get; set; }
        public decimal? IdTitTipoTitolo { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string DescAppendice { get; set; }
        public decimal? CodDeroga { get; set; }
    }
}
