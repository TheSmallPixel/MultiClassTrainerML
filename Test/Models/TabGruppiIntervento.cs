using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabGruppiIntervento
    {
        public int KeyGruppoIntervento { get; set; }
        public int IdGruppoIntervento { get; set; }
        public string CodiceGruppoIntervento { get; set; }
        public decimal? PercCapitaleAssicurato { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
        public string CodTariffa { get; set; }
        public decimal? Importo { get; set; }
        public string Edizione { get; set; }
    }
}
