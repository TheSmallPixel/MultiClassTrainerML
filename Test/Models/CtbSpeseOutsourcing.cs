using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CtbSpeseOutsourcing
    {
        public int KeySpesaOutsourcing { get; set; }
        public int IdSpesaOutsourcing { get; set; }
        public int IdCompagnia { get; set; }
        public int IdSinistro { get; set; }
        public int IdFiduciario { get; set; }
        public DateTime DtUltimaElaborazione { get; set; }
        public decimal? ImpSpesaCalcolata { get; set; }
        public string Note { get; set; }
        public int IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
    }
}
