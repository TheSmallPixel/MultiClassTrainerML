using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RuoliRete
    {
        public int KeyRuoloRete { get; set; }
        public int IdRuoloRete { get; set; }
        public int IdAnagrafica { get; set; }
        public string FlgTipoVenditore { get; set; }
        public int? IdSegnalatore { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
        public string Note { get; set; }
        public DateTime DtIniRapporto { get; set; }
        public DateTime DtFinRapporto { get; set; }
        public string FlgValutazionePraxi { get; set; }
        public string FlgCanaleReclutamentoDp2 { get; set; }
        public string FlgAxaCampus { get; set; }
        public DateTime? DtAxaCampus { get; set; }
    }
}
