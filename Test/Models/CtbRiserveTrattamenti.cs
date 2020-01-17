using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CtbRiserveTrattamenti
    {
        public int KeyRiservaTrattamento { get; set; }
        public int IdRiservaTrattamento { get; set; }
        public int IdMalattiatrattamento { get; set; }
        public int IdEntitacoinvolta { get; set; }
        public int IdSinistro { get; set; }
        public int IdGaranzia { get; set; }
        public decimal ImpRiserva { get; set; }
        public int? IdValuta { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
        public int? IdDeroga { get; set; }
        public int? IdTariffa { get; set; }
    }
}
