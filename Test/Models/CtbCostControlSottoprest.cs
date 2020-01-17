using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CtbCostControlSottoprest
    {
        public int IdCostControlSottoprest { get; set; }
        public int IdSottoprestazione { get; set; }
        public int IdSinistro { get; set; }
        public int IdEntitacoinvolta { get; set; }
        public int? IdIndennizzo { get; set; }
        public int? IdDeroga { get; set; }
        public string CodPrestazioneMed { get; set; }
        public decimal? Importo { get; set; }
    }
}
