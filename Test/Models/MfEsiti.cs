using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class MfEsiti
    {
        public decimal KeyMfEsito { get; set; }
        public decimal IdMfEsito { get; set; }
        public decimal IdMfDato { get; set; }
        public string FlgTipoEsitoMf { get; set; }
        public DateTime? DtEsito { get; set; }
        public DateTime? CompetenzaEsito { get; set; }
        public decimal? IdMfPvAbbinamento { get; set; }
        public DateTime? DtSysEsito { get; set; }
        public decimal IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public DateTime? DtScaricoContabile { get; set; }
    }
}
