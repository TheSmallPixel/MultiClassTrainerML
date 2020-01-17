using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcNomineAlboAgenti
    {
        public decimal KeyArcNominaAlboAgenti { get; set; }
        public decimal IdArcNominaAlboAgenti { get; set; }
        public decimal IdRetevendita { get; set; }
        public decimal IdAnagrafica { get; set; }
        public DateTime DtNomina { get; set; }
        public DateTime? DtRevoca { get; set; }
        public string FlgMotRevMandAlboAgenti { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal? PercQuotaCpa { get; set; }
        public decimal? PercQuotaCpa01 { get; set; }
        public decimal? PercQuotaCpa02 { get; set; }
        public DateTime? DtAnzianitaGest01 { get; set; }
        public DateTime? DtAnzianitaGest02 { get; set; }
        public string FlgAxaCampus { get; set; }
        public DateTime? DtAxaCampus { get; set; }
    }
}
