using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TitRateDati
    {
        public int KeyTitRateDati { get; set; }
        public int IdTitRateDati { get; set; }
        public int? IdPagatore { get; set; }
        public int? IdContocorrentePagatore { get; set; }
        public int? IdContocorrenteAccredito { get; set; }
        public int? NumeroRate { get; set; }
        public string FlgTipoRateizzazione { get; set; }
        public DateTime? DtInizioRateizzazione { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
    }
}
