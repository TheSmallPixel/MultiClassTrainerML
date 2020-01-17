using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CtbFattureEstereDett
    {
        public int KeyFatturaDett { get; set; }
        public int IdFatturaDett { get; set; }
        public int? IdFatturaEstera { get; set; }
        public int? IdSpesa { get; set; }
        public int? IdIndennizzo { get; set; }
        public int? IdRecupero { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
    }
}
