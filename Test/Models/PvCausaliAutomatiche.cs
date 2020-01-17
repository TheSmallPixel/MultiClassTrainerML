using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PvCausaliAutomatiche
    {
        public decimal IdPvCausaleAutomatica { get; set; }
        public decimal? IdCompagnia { get; set; }
        public string FlgCodCauAutomatica { get; set; }
        public decimal? IdPvCausalePositiva { get; set; }
        public decimal? IdPvCausaleNegativa { get; set; }
    }
}
