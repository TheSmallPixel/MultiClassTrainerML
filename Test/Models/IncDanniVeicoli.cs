using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class IncDanniVeicoli
    {
        public int KeyIncaricodannoveicolo { get; set; }
        public int IdIncaricodannoveicolo { get; set; }
        public int IdSinistro { get; set; }
        public int IdEntitacoinvolta { get; set; }
        public int IdIncarico { get; set; }
        public string FlgPuntoUrto { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
