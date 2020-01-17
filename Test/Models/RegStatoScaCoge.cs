using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RegStatoScaCoge
    {
        public decimal IdStatoScaricoCoge { get; set; }
        public DateTime DataPeriodoDa { get; set; }
        public DateTime DataPeriodoA { get; set; }
        public string FlgTipoScaricoCoge { get; set; }
        public DateTime DataScarico { get; set; }
        public string FlgStatoScarico { get; set; }
        public decimal IdCompagnia { get; set; }
        public string Note { get; set; }
    }
}
