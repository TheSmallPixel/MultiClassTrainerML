using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArRaccordoRami
    {
        public decimal KeyArRaccordo { get; set; }
        public decimal IdArRaccordo { get; set; }
        public decimal IdArSottogruppo { get; set; }
        public string FlgRamoAttivita { get; set; }
        public string FlgSettorizzazioneSintetica { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
