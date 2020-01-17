using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysUtentiGruppoColl
    {
        public decimal IdUtenteGruppo { get; set; }
        public decimal IdUtente { get; set; }
        public string FlgRuoloGruppo { get; set; }
        public DateTime? DtIniVal { get; set; }
        public DateTime? DtFinVal { get; set; }
        public string FlgDisabilitaNotificheSino { get; set; }
        public string FlgDisabilitaMailSino { get; set; }
        public string FlgResponsabileSino { get; set; }
    }
}
