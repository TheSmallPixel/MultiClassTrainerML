using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class QueQuerele
    {
        public int KeyQuerela { get; set; }
        public int IdQuerela { get; set; }
        public int IdLegale { get; set; }
        public string NRepertorio { get; set; }
        public DateTime DtDeposito { get; set; }
        public string FlgParteOffesaSino { get; set; }
        public int? IdFase { get; set; }
        public string Note { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgParteCivileSino { get; set; }
        public DateTime? DtCostituzioneParteCivile { get; set; }
        public string FlgMultisinistroSino { get; set; }
        public string FlgGradoCuria { get; set; }
        public string FlgTipoCuria { get; set; }
        public int? IdIndirizzo { get; set; }
    }
}
