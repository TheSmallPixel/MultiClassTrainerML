using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcMandatiAlboAgentiR
    {
        public decimal KeyArcMandatoAlboAgentiR { get; set; }
        public decimal IdArcMandatoAlboAgentiR { get; set; }
        public decimal IdArcMandatoAlboAgenti { get; set; }
        public string FlgTipoMandatoAlboAgenti { get; set; }
        public string FlgEmissioneDirettaSino { get; set; }
        public DateTime? DtEmissioneDirettaDal { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdUtente { get; set; }
    }
}
