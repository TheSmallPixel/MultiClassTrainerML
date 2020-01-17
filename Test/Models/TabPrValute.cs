using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabPrValute
    {
        public decimal KeyPrValuta { get; set; }
        public decimal? IdPrValuta { get; set; }
        public decimal? IdValuta { get; set; }
        public decimal? IdProdotto { get; set; }
        public string CodValuta { get; set; }
        public decimal? IdDescrizione { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string Descrizione { get; set; }
    }
}
