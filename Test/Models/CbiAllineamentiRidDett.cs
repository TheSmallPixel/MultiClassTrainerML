using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CbiAllineamentiRidDett
    {
        public int IdAllineamentoDett { get; set; }
        public int IdAllineamento { get; set; }
        public string FlgStatoRichiesta { get; set; }
        public DateTime DtStato { get; set; }
        public string FlgMotivoDiniego { get; set; }
        public string FlgCodiceCausale { get; set; }
        public string FlgInviatoRicevuto { get; set; }
        public string TestoInviato { get; set; }
        public string NomeFile { get; set; }
    }
}
