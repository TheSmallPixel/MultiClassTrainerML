using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysSchedulazioniJob
    {
        public int KeySchedulazioneJob { get; set; }
        public int IdSchedulazioneJob { get; set; }
        public int? IdJob { get; set; }
        public string FlgPeriodicitaJob { get; set; }
        public string FlgValorePeriodicita { get; set; }
        public string OraInizioPrevista { get; set; }
        public string OraFinePrevista { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
