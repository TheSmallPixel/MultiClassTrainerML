using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SimRinnovoGaranzie
    {
        public int KeySimRinnovoGar { get; set; }
        public int IdSimRinnovoGar { get; set; }
        public int? IdSimRinnovoPol { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdPolizza { get; set; }
        public int? IdPrGaranzia { get; set; }
        public int? IdPrGarScomposizione { get; set; }
        public int? IdUtente { get; set; }
        public string CodGaranzia { get; set; }
        public string DescGaranzia { get; set; }
        public string FlgRamoBilancio { get; set; }
        public decimal? ImpNetto { get; set; }
        public decimal? ImpTasse { get; set; }
        public decimal? ImpSsn { get; set; }
        public decimal? ImpAccessori { get; set; }
        public decimal? ImpLordo { get; set; }
        public decimal? ImpFranchigiaAgg { get; set; }
        public decimal? ImpNettoAnnuo { get; set; }
        public decimal? ImpScontabileRinnovo { get; set; }
    }
}
