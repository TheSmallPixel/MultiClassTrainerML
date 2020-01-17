using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class DocParagrafi
    {
        public decimal IdDocParagrafo { get; set; }
        public decimal? IdDocMaster { get; set; }
        public string CodParagrafo { get; set; }
        public decimal? IdDescrizione { get; set; }
        public string FlgObbligatorioSino { get; set; }
        public string Descrizione { get; set; }
    }
}
