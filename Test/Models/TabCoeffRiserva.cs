using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabCoeffRiserva
    {
        public decimal KeyCoeffRiserva { get; set; }
        public int IdCoeffRiserva { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
        public int? AnnoAccadimento { get; set; }
        public string FlgRamoBilancio { get; set; }
        public DateTime? PeriodoRiferimento { get; set; }
        public string TipoGestione { get; set; }
        public decimal? Coefficiente { get; set; }
    }
}
