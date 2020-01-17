using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabQuestionariIdd
    {
        public int KeyQuestionarioIdd { get; set; }
        public int IdQuestionarioIdd { get; set; }
        public string CodQuestionarioIdd { get; set; }
        public int IdDescrizione { get; set; }
        public string Descrizione { get; set; }
        public DateTime DtInizioValidita { get; set; }
        public DateTime DtFineValidita { get; set; }
        public int IdFormula { get; set; }
        public int IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
