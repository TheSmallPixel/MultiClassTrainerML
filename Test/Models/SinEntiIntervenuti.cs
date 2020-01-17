using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinEntiIntervenuti
    {
        public decimal KeyEnteintervenuto { get; set; }
        public decimal? IdEnteintervenuto { get; set; }
        public decimal? IdAnagrafica { get; set; }
        public decimal? IdUtente { get; set; }
        public string FlgTipoEnte { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal IdEntitacoinvolta { get; set; }
        public int? IdCarrozzeriaConvenzionata { get; set; }
    }
}
