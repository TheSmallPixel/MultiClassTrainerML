using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinPatrocinatori
    {
        public decimal IdPatrocinatore { get; set; }
        public decimal IdAnagrafica { get; set; }
        public decimal? IdEntitacoinvolta { get; set; }
        public decimal KeyPatrocinatore { get; set; }
        public decimal IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
    }
}
