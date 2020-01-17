using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrEleValVariabili
    {
        public decimal KeyPrElencoValori { get; set; }
        public decimal IdPrElencoValori { get; set; }
        public decimal? IdPrElencoValoriPrin { get; set; }
        public decimal IdPrVariabile { get; set; }
        public string CodParametro { get; set; }
        public decimal? IdDescrizione { get; set; }
        public string FlgFormatoVariabile { get; set; }
        public string ValoreStringa { get; set; }
        public DateTime? ValoreData { get; set; }
        public decimal? ValoreNumerico { get; set; }
        public decimal? Ordine { get; set; }
        public decimal? IdUtente { get; set; }
        public string FlgNonInElencoSino { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string Descrizione { get; set; }
    }
}
