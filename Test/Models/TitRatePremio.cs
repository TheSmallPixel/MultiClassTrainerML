using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TitRatePremio
    {
        public int KeyTitRatePremio { get; set; }
        public int IdTitRatePremio { get; set; }
        public int? IdTitRateDati { get; set; }
        public DateTime? DtEffettoRata { get; set; }
        public DateTime? DtScadenzaRata { get; set; }
        public DateTime? DtEsitoRata { get; set; }
        public decimal? Importo { get; set; }
        public string FlgStatoRata { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
        public int? NumeroRata { get; set; }
    }
}
