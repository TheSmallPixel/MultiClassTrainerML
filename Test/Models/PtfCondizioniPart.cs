using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PtfCondizioniPart
    {
        public int KeyCondizionePart { get; set; }
        public int IdCondizionePart { get; set; }
        public int IdPolizza { get; set; }
        public string CondizionePart { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
        public int? IdBene { get; set; }
    }
}
