using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CklPratiche
    {
        public decimal IdPratica { get; set; }
        public decimal IdOggetto { get; set; }
        public string FlgTipoOggetto { get; set; }
        public string RifEsterno { get; set; }
        public string DtSysInserimento { get; set; }
        public string DtSysInvioDocumentale { get; set; }
        public string DtSysUltimoAggiornamento { get; set; }
        public decimal? IdUtente { get; set; }
    }
}
