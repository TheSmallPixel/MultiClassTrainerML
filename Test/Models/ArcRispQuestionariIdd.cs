using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcRispQuestionariIdd
    {
        public int KeyRispQuestionarioIdd { get; set; }
        public int IdRispQuestionarioIdd { get; set; }
        public int IdQuestionarioIdd { get; set; }
        public int? IdAnagrafica { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
    }
}
