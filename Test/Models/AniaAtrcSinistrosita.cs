using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaAtrcSinistrosita
    {
        public int IdAtrcSinistrosita { get; set; }
        public int IdRichiestaAtrc { get; set; }
        public int IdRichiestaIbd { get; set; }
        public string FlgTipologiaSinistro { get; set; }
        public string AnnoRiferimento { get; set; }
        public string NumeroSinistri { get; set; }
    }
}
