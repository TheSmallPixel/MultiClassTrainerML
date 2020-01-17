using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PvEsiti
    {
        public decimal KeyPvEsito { get; set; }
        public decimal? IdPvEsito { get; set; }
        public decimal? IdPvDato { get; set; }
        public string FlgTipoEsito { get; set; }
        public DateTime? DtEsito { get; set; }
        public decimal? IdTabMotivoStorno { get; set; }
        public decimal? IdAgenziaEsito { get; set; }
        public decimal? ImpIncassatoDare { get; set; }
        public decimal? ImpIncassatoAvere { get; set; }
        public DateTime? CompetenzaEsito { get; set; }
        public decimal? IdCntFogliocassa { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtSysEsito { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdMfPvAbbinamento { get; set; }
        public string FlgMezzoPagamento { get; set; }
        public DateTime? DtScaricoContabile { get; set; }
    }
}
