using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrVariabiliEntita
    {
        public decimal KeyPrVariabileEntita { get; set; }
        public decimal IdPrVariabileEntita { get; set; }
        public decimal? IdPrProdotto { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal? IdPrGaranzia { get; set; }
        public decimal? IdPrBene { get; set; }
        public decimal? IdPrGruppoVariabili { get; set; }
        public decimal? Ordine { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgRichiestaFinePolSino { get; set; }
    }
}
