using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrVarDinamiche
    {
        public decimal KeyPrVarDinamica { get; set; }
        public decimal? IdPrVarDinamica { get; set; }
        public string FlgTipoEntitaVar { get; set; }
        public decimal IdPrProdotto { get; set; }
        public decimal? IdElencoValore { get; set; }
        public string ValoreStringa { get; set; }
        public decimal? ValoreNumerico { get; set; }
        public DateTime? ValoreData { get; set; }
        public decimal IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
