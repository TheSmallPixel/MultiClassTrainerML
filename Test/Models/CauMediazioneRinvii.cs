using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CauMediazioneRinvii
    {
        public int IdRinvio { get; set; }
        public int IdMediazione { get; set; }
        public DateTime DtRinvio { get; set; }
        public string Note { get; set; }
    }
}
