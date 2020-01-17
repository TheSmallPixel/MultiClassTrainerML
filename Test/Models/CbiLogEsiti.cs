using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CbiLogEsiti
    {
        public decimal IdLogEsiti { get; set; }
        public string NomeFile { get; set; }
        public DateTime? DtCaricamento { get; set; }
        public string FlgStatoEsito { get; set; }
        public decimal? IdCompagnia { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtElaborazione { get; set; }
        public string FlgTipoEsitoCbi { get; set; }
    }
}
