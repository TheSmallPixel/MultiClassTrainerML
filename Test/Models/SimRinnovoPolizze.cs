using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SimRinnovoPolizze
    {
        public int KeySimRinnovoPol { get; set; }
        public int IdSimRinnovoPol { get; set; }
        public int? IdPolizza { get; set; }
        public int? IdPrProdotto { get; set; }
        public int IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public DateTime? DtEffettoRata { get; set; }
        public DateTime? DtScadenzaRata { get; set; }
        public DateTime? DtEffettoPolizza { get; set; }
        public DateTime? DtScadenzaPolizza { get; set; }
        public decimal? ImpNetto { get; set; }
        public decimal? ImpTasse { get; set; }
        public decimal? ImpSsn { get; set; }
        public decimal? ImpAccessori { get; set; }
        public decimal? ImpLordo { get; set; }
        public decimal? ImpFranchigiaAgg { get; set; }
        public string ClasseCuProvenienza { get; set; }
        public string ClasseCuAssegnazione { get; set; }
        public string ClasseCompProvenienza { get; set; }
        public string ClasseCompAssegnazione { get; set; }
        public string FlgTipoPejus { get; set; }
        public string FlgStatoRinnovo { get; set; }
    }
}
