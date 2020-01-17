using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class EtaAssSegnalazioni
    {
        public int IdEtaAssSegnalazione { get; set; }
        public int? IdPolizza { get; set; }
        public int? IdCompagnia { get; set; }
        public int? IdAnagrafica { get; set; }
        public string NPolizza { get; set; }
        public DateTime? DtEffettoPolizza { get; set; }
        public DateTime? DtScadenzaPolizza { get; set; }
        public string CodCompagniaAnia { get; set; }
        public string CognomeRagioneSocialeAss { get; set; }
        public string CodfiscPivaAss { get; set; }
        public DateTime? DtNascitaAss { get; set; }
        public int? EtaSegnalazioneBeneAss { get; set; }
        public string DtSysElaborazione { get; set; }
        public DateTime? DtElaborazione { get; set; }
        public DateTime? DtIniEstrazione { get; set; }
        public DateTime? DtFineEstrazione { get; set; }
    }
}
