using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ScaPeriodoPortafoglio
    {
        public decimal IdPeriodoPortafoglio { get; set; }
        public decimal? IdCompagnia { get; set; }
        public DateTime? DtEffettoVal { get; set; }
        public DateTime? DtScadenzaVal { get; set; }
        public DateTime? DtCompetenza { get; set; }
        public DateTime? DtSysRegistrazione { get; set; }
        public decimal? IdUtente { get; set; }
    }
}
