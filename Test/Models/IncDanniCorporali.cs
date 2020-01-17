using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class IncDanniCorporali
    {
        public int KeyIncaricodannocorporale { get; set; }
        public int IdIncaricodannocorporale { get; set; }
        public int IdSinistro { get; set; }
        public int IdEntitacoinvolta { get; set; }
        public int IdIncarico { get; set; }
        public string FlgProntoSoccorsoSino { get; set; }
        public int? IdAnagraficaOspedale { get; set; }
        public decimal? PctInvaliditaPerm { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
