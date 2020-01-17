using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabQuery
    {
        public int IdTabQuery { get; set; }
        public string FlgAreaQuery { get; set; }
        public string CodQuery { get; set; }
        public int? IdDescrizione { get; set; }
        public string Descrizione { get; set; }
        public string StringaSql { get; set; }
    }
}
