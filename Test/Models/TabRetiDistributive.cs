using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabRetiDistributive
    {
        public int IdRetedistributiva { get; set; }
        public int? IdCompagniegruppo { get; set; }
        public int? IdDescrizione { get; set; }
        public string CodReteDistributiva { get; set; }
        public string Descrizione { get; set; }
        public DateTime? DtInizioValidita { get; set; }
        public DateTime? DtFineValidita { get; set; }
    }
}
