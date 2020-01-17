using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CtbSpeseOutsourcingDett
    {
        public int KeySpesaOutsourcingDett { get; set; }
        public int IdSpesaOutsourcingDett { get; set; }
        public int IdSpesaOutsourcing { get; set; }
        public int IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public int IdTabSpesaOutsourcing { get; set; }
        public int IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
    }
}
