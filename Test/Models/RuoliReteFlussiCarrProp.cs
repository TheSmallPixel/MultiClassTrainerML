using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RuoliReteFlussiCarrProp
    {
        public int IdRuoloReteFlussiCarrProp { get; set; }
        public DateTime? DtFlusso { get; set; }
        public int? Progressivo { get; set; }
        public string NomeFile { get; set; }
        public string FlgPresenzaErroriSino { get; set; }
    }
}
