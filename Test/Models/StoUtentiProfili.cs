using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class StoUtentiProfili
    {
        public int IdUtenteprofilo { get; set; }
        public int IdProfilo { get; set; }
        public int IdUtente { get; set; }
        public int IdStoricoUtente { get; set; }
        public string DtStorico { get; set; }
        public string FlgCancellatoSino { get; set; }
    }
}
