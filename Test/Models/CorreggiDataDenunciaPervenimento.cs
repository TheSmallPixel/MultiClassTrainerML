using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CorreggiDataDenunciaPervenimento
    {
        public DateTime DtDenuncia { get; set; }
        public DateTime DtPervenimentoDenuncia { get; set; }
        public string NSinistro { get; set; }
        public decimal AnnoEsercizio { get; set; }
        public decimal? IdCompagnia { get; set; }
    }
}
