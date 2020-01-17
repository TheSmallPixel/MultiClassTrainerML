using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class StoUtentiIspettorati
    {
        public int IdUtenteIspettorato { get; set; }
        public int IdUtente { get; set; }
        public int IdIspettorato { get; set; }
        public int IdStoricoUtente { get; set; }
        public string DtStorico { get; set; }
        public string FlgCancellatoSino { get; set; }
    }
}
