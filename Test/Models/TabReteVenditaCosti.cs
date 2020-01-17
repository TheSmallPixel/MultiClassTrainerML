using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaCosti
    {
        public decimal KeyRetevenditaCosto { get; set; }
        public decimal IdRetevenditaCosto { get; set; }
        public decimal IdCompagnia { get; set; }
        public decimal IdRetevendita { get; set; }
        public decimal IdConto { get; set; }
        public decimal? IdDescrizione { get; set; }
        public string CodGestione { get; set; }
        public string Note { get; set; }
        public decimal? ImpRata { get; set; }
        public decimal? IdValuta { get; set; }
        public decimal? NumeroRate { get; set; }
        public string FlgFrequenzaRate { get; set; }
        public DateTime? DtRateDal { get; set; }
        public DateTime? DtRateAl { get; set; }
        public string FlgValutazioneCosto { get; set; }
        public DateTime? DtCompetenzaDal { get; set; }
        public DateTime? DtCompetenzaAl { get; set; }
        public decimal? ImpObbAuto { get; set; }
        public decimal? ImpObbRe { get; set; }
        public decimal? ImpObbVpa { get; set; }
        public decimal? ImpObbVpu { get; set; }
        public decimal? ImpObbVtot { get; set; }
        public string CodSubagente { get; set; }
        public string DescSubagente { get; set; }
        public string CodCosto { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal IdUtente { get; set; }
        public string Descrizione { get; set; }
    }
}
