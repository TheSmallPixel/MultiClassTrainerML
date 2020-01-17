using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PtfContraenti
    {
        public decimal KeyContraentepolizza { get; set; }
        public decimal? IdContraentepolizza { get; set; }
        public decimal? IdAnagrafica { get; set; }
        public string NoteContraente { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal IdPolizza { get; set; }
    }
}
