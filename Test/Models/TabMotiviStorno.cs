using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabMotiviStorno
    {
        public decimal KeyTabMotivoStorno { get; set; }
        public decimal IdTabMotivoStorno { get; set; }
        public decimal IdCompagnia { get; set; }
        public string CodStorno { get; set; }
        public decimal IdDescStorno { get; set; }
        public string FlgAnnullamentoSino { get; set; }
        public string FlgStornoSino { get; set; }
        public string FlgPolizzeSino { get; set; }
        public string FlgAnnTitoliSino { get; set; }
        public string FlgAnnPvSino { get; set; }
        public string FlgStornoTitoliSino { get; set; }
        public string FlgStornoPvSino { get; set; }
        public string FlgTipoAnnullamento { get; set; }
        public string FlgAutorizzazioneSino { get; set; }
        public string FlgRimborsoSino { get; set; }
        public string FlgRestituzioneSino { get; set; }
        public decimal? IdUtente { get; set; }
        public string FlgReadonlySino { get; set; }
        public string FlgRimborsoProvvSino { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgTrattativaSino { get; set; }
        public string DescStorno { get; set; }
        public string FlgStornoOperSino { get; set; }
        public string FlgSenzaEffettoSino { get; set; }
        public string FlgSoggDirittiRimborsoSino { get; set; }
        public string FlgSoloDirezioneSino { get; set; }
        public decimal? CodDeroga { get; set; }
        public string FlgRisDirezioneSino { get; set; }
        public string FlgRimbPlafondSino { get; set; }
        public string FlgRimbPlafondProRataSino { get; set; }
        public string FlgSbloccaAnnInsPrecSino { get; set; }
        public string FlgProposteSino { get; set; }
        public string FlgCauAnnSita { get; set; }
        public string FlgScadRataSino { get; set; }
    }
}
