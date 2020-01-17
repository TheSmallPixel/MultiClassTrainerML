using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabRami
    {
        public decimal KeyRamo { get; set; }
        public decimal? IdRamo { get; set; }
        public decimal? IdCompagnia { get; set; }
        public string CodRamo { get; set; }
        public decimal? IdDescrizione { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string Descrizione { get; set; }
    }
}
