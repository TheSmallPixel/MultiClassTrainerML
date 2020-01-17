using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CklChecklist
    {
        public decimal IdChecklist { get; set; }
        public decimal? IdOperazione { get; set; }
        public string FlgMacroTipologiaAllegato { get; set; }
        public string FlgTipologiaAllegato { get; set; }
        public string FlgStatoDocumento { get; set; }
        public decimal? IdAllegato { get; set; }
        public string DtSysInserimento { get; set; }
        public string DtSysInvioDocumentale { get; set; }
        public string DtSysUltimoAggiornamento { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal? IdAnagrafica { get; set; }
    }
}
