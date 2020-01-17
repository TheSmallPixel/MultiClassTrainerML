using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PtfProprietari
    {
        public decimal KeyProprietario { get; set; }
        public decimal? IdProprietario { get; set; }
        public decimal? IdAnagrafica { get; set; }
        public string NoteProprietario { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdBene { get; set; }
    }
}
