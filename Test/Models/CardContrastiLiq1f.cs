using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CardContrastiLiq1f
    {
        public int IdCardContrastiLiq1f { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdIndennizzo { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public decimal? Importo { get; set; }
        public decimal? PercentualeRespLiq { get; set; }
    }
}
