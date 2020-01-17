using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabNetwork
    {
        public int IdNetwork { get; set; }
        public string Codice { get; set; }
        public string Descrizione { get; set; }
        public int? IdFiduciario { get; set; }
        public int? IdLiquidatore { get; set; }
        public DateTime? DtInizioValidita { get; set; }
        public DateTime? DtFineValidita { get; set; }
        public string FlgCreaIncaricoSino { get; set; }
    }
}
