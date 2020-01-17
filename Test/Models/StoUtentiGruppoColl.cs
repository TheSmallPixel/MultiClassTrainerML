using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class StoUtentiGruppoColl
    {
        public int IdUtenteGruppo { get; set; }
        public int IdUtente { get; set; }
        public string FlgRuoloGruppo { get; set; }
        public DateTime? DtIniVal { get; set; }
        public DateTime? DtFinVal { get; set; }
        public string FlgDisabilitaNotificheSino { get; set; }
        public string FlgDisabilitaMailSino { get; set; }
        public string FlgResponsabileSino { get; set; }
        public int IdStoricoUtente { get; set; }
        public string DtStorico { get; set; }
        public string FlgCancellatoSino { get; set; }
    }
}
