using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AaLogModifiche
    {
        public DateTime? DtModifica { get; set; }
        public string Comando { get; set; }
        public string TipoOggetto { get; set; }
        public string NomeSchema { get; set; }
        public string NomeOggetto { get; set; }
        public string SqlText { get; set; }
    }
}
