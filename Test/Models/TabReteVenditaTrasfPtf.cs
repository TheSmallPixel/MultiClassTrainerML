using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaTrasfPtf
    {
        public decimal KeyRetevenditaTrasfPtf { get; set; }
        public decimal IdRetevenditaTrasfPtf { get; set; }
        public string FlgMacroRamo { get; set; }
        public string FlgParzTot { get; set; }
        public DateTime DtTrasf { get; set; }
        public decimal IdAgeRicevente { get; set; }
        public string FlgTrasfInSeguito { get; set; }
        public decimal IdRetevendita { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal IdUtente { get; set; }
        public string CodGestione { get; set; }
        public decimal? Importo { get; set; }
    }
}
