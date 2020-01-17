using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class StoAbilitazioniFunz
    {
        public int IdAbilitazioneFunz { get; set; }
        public int IdProfilo { get; set; }
        public string CodFunzione { get; set; }
        public string ValoriParametroEccezioni { get; set; }
        public int IdStoricoUtente { get; set; }
        public string DtStorico { get; set; }
        public string FlgCancellatoSino { get; set; }
    }
}
