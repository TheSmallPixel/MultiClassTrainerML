using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabImportiMediazione
    {
        public int IdImportomediazione { get; set; }
        public string CodParametri { get; set; }
        public decimal ImpValore { get; set; }
        public int IdValuta { get; set; }
        public int? IdDescrizione { get; set; }
        public string Descrizione { get; set; }
    }
}
