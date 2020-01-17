using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class DocMacroProcessi
    {
        public decimal IdDocMacroprocesso { get; set; }
        public string CodMacroProcesso { get; set; }
        public decimal? IdDescrizione { get; set; }
        public DateTime? DtInizioVal { get; set; }
        public DateTime? DtFineVal { get; set; }
        public string Descrizione { get; set; }
    }
}
