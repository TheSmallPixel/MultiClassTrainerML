using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CklOperazioni
    {
        public decimal IdOperazione { get; set; }
        public decimal? IdPratica { get; set; }
        public string RifEsterno { get; set; }
        public string FlgStatoOperazione { get; set; }
        public decimal IdOggetto { get; set; }
        public string FlgTipoOggetto { get; set; }
        public string DtSysInserimento { get; set; }
        public string DtSysInvioDocumentale { get; set; }
        public string DtSysUltimoAggiornamento { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal? IdAnagrafica { get; set; }
        public string FlgTipoOperazione { get; set; }
    }
}
