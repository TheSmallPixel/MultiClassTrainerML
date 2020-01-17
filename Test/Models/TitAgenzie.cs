using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TitAgenzie
    {
        public decimal KeyTitAgenzia { get; set; }
        public decimal? IdTitAgenzia { get; set; }
        public decimal? IdTitTitolo { get; set; }
        public decimal IdRetevendita { get; set; }
        public decimal? Livello { get; set; }
        public decimal? IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
