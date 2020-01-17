using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabCanaliDistribuzione
    {
        public int IdCanaledistribuzione { get; set; }
        public int IdRetedistributiva { get; set; }
        public int? IdDescrizione { get; set; }
        public string CodCanaleDistribuzione { get; set; }
        public string Descrizione { get; set; }
        public DateTime? DtInizioValidita { get; set; }
        public DateTime? DtFineValidita { get; set; }
    }
}
