using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RepModelliAttivita
    {
        public int IdModelloAttivita { get; set; }
        public int? IdModello { get; set; }
        public string FlgTipoAttivita { get; set; }
        public string FlgTipoOggetto { get; set; }
    }
}
