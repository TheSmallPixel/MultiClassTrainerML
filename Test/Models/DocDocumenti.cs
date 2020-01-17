using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class DocDocumenti
    {
        public decimal IdDocDocumento { get; set; }
        public decimal? IdDocProcesso { get; set; }
        public string CodDocumento { get; set; }
        public decimal? IdDescrizione { get; set; }
        public DateTime? DtInizioVal { get; set; }
        public DateTime? DtFineVal { get; set; }
        public string Descrizione { get; set; }
    }
}
