using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinAutoritaIntervenute
    {
        public decimal KeyAutoritaintervenuta { get; set; }
        public decimal? IdAutoritaintervenuta { get; set; }
        public decimal? IdAnagrafica { get; set; }
        public decimal? IdUtente { get; set; }
        public string FlgTipoAutorita { get; set; }
        public string FlgVerbaleSino { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal IdSinistro { get; set; }
        public decimal? IdComune { get; set; }
        public string Note { get; set; }
    }
}
