using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabDipCommComp
    {
        public decimal KeyDipartimentoCompagnia { get; set; }
        public decimal IdDipartimentoCompagnia { get; set; }
        public decimal IdCompagnia { get; set; }
        public decimal IdDipartimento { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdUtente { get; set; }
    }
}
