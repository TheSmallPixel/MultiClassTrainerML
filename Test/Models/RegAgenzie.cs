using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RegAgenzie
    {
        public decimal KeyRegAgenzia { get; set; }
        public decimal? IdRegAgenzia { get; set; }
        public decimal? IdRegTitolo { get; set; }
        public decimal IdRetevendita { get; set; }
        public decimal? Livello { get; set; }
        public decimal? IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
