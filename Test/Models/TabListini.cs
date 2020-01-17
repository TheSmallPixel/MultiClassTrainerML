using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabListini
    {
        public int IdListino { get; set; }
        public string Descrizione { get; set; }
        public string Note { get; set; }
        public DateTime? DtInizioValidita { get; set; }
        public DateTime? DtFineValidita { get; set; }
    }
}
