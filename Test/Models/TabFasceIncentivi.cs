using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabFasceIncentivi
    {
        public int IdFasciaIncentivo { get; set; }
        public int IdTipoIncentivo { get; set; }
        public decimal? PercentualeDa { get; set; }
        public decimal? PercentualeA { get; set; }
        public decimal? Importo { get; set; }
        public DateTime DtInizio { get; set; }
        public DateTime DtFine { get; set; }
    }
}
