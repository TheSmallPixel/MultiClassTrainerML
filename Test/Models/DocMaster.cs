using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class DocMaster
    {
        public decimal IdDocMaster { get; set; }
        public decimal? IdDocDocumento { get; set; }
        public string CodMaster { get; set; }
        public decimal? IdDescrizione { get; set; }
        public decimal? IdModello { get; set; }
        public DateTime? DtInizioVal { get; set; }
        public DateTime? DtFineVal { get; set; }
        public string Descrizione { get; set; }
        public string ClasseDocumentale { get; set; }
    }
}
