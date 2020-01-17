using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AnaLegami
    {
        public decimal KeyLegame { get; set; }
        public decimal IdLegame { get; set; }
        public decimal IdAnagraficaLegame { get; set; }
        public decimal IdTabLegame { get; set; }
        public decimal IdUtente { get; set; }
        public decimal IdAnagrafica { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdNucleoFamiliare { get; set; }
    }
}
