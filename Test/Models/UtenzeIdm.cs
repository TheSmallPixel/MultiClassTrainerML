using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class UtenzeIdm
    {
        public int KeyUtenzeidm { get; set; }
        public int IdUtenzeidm { get; set; }
        public int IdUtentewise { get; set; }
        public string Idmsystem { get; set; }
        public string Idmuser { get; set; }
        public int IdCompagnia { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
