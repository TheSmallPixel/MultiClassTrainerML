using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaRaccordoErroriCard
    {
        public int IdAniaRaccordoErroriCard { get; set; }
        public int IdAniaErroriCard { get; set; }
        public int IdAniaCardDettaglio { get; set; }
        public string FlgTipoFlusso { get; set; }
    }
}
