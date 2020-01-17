using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaRTrasfPtf
    {
        public int KeyRetevenditaRTrasfPtf { get; set; }
        public int IdRetevenditaRTrasfPtf { get; set; }
        public int IdRetevendita { get; set; }
        public string CodGestione { get; set; }
        public int IdRetevenditaCedente { get; set; }
        public int IdRetevenditaRicevente { get; set; }
        public DateTime DtEffettoTrasferimento { get; set; }
        public DateTime DtRichiestaTrasferimento { get; set; }
        public string FlgMacroRamoRTrasfPtf { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
