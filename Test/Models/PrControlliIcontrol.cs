using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrControlliIcontrol
    {
        public decimal KeyControlloIcontrol { get; set; }
        public decimal IdControlloIcontrol { get; set; }
        public decimal IdPrProdotto { get; set; }
        public string FlgPaginaControllo { get; set; }
        public string MetodoIcontrol { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? CodDerogaIcontrol { get; set; }
    }
}
