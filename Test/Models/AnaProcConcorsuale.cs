using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AnaProcConcorsuale
    {
        public decimal KeyAnaProcConcorsuale { get; set; }
        public decimal IdAnaProcConcorsuale { get; set; }
        public decimal? IdAnagrafica { get; set; }
        public DateTime? DtApertura { get; set; }
        public string FlgTipoProc { get; set; }
        public decimal? IdComuneProc { get; set; }
        public decimal? IdAnagraficaCuratore { get; set; }
        public decimal? IdAnagraficaLiquidatore { get; set; }
        public decimal? IdAnagraficaCommissario { get; set; }
        public string EMailPec { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdUtente { get; set; }
    }
}
