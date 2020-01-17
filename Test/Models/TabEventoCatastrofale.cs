using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabEventoCatastrofale
    {
        public int KeyEventoCatastrofale { get; set; }
        public int IdEventoCatastrofale { get; set; }
        public DateTime DtEventoCatastrofale { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string Note { get; set; }
        public int? IdIndirizzo { get; set; }
        public int IdUtente { get; set; }
        public DateTime? DtFineEvento { get; set; }
        public int? IdTipoEventoCatastrofale { get; set; }
    }
}
