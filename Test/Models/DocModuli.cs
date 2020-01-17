using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class DocModuli
    {
        public decimal IdDocModulo { get; set; }
        public decimal? IdDocParagrafo { get; set; }
        public string CodModulo { get; set; }
        public decimal? IdDescrizione { get; set; }
        public string Descrizione { get; set; }
    }
}
