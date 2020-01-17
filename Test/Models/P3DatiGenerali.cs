using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class P3DatiGenerali
    {
        public int KeyP3DatiGenerali { get; set; }
        public int IdP3DatiGenerali { get; set; }
        public int IdAnagrafica { get; set; }
        public int IdDipartimento { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
        public string Note { get; set; }
        public DateTime? DtIniRapporto { get; set; }
        public DateTime? DtFinRapporto { get; set; }
        public int? IdCausale { get; set; }
    }
}
