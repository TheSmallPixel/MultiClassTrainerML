using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaRaccordiErroriFunzioni
    {
        public int IdAniaRaccErroriFunzioni { get; set; }
        public int? IdAniaErroriCard { get; set; }
        public int? IdAniaSca { get; set; }
        public string FlgTipoFlusso { get; set; }
    }
}
