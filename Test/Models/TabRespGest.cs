using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabRespGest
    {
        public decimal KeyResponsabileGest { get; set; }
        public decimal IdResponsabileGest { get; set; }
        public string CodResponsabileGest { get; set; }
        public decimal IdAnagrafica { get; set; }
        public decimal IdDipartimento { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdUtente { get; set; }
    }
}
