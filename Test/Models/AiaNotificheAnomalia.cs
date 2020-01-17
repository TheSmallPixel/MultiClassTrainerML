using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AiaNotificheAnomalia
    {
        public int KeyNotificheAnomalia { get; set; }
        public int IdNotificheAnomalia { get; set; }
        public string CodNotif { get; set; }
        public string CodImpr { get; set; }
        public string Causale { get; set; }
        public string TipoCont { get; set; }
        public DateTime OraElab { get; set; }
        public string CodRich { get; set; }
        public decimal NumSini { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
        public int? IdCompagnia { get; set; }
    }
}
