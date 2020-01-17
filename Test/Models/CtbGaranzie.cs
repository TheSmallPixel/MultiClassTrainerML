using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CtbGaranzie
    {
        public decimal IdGaranziapagata { get; set; }
        public decimal? IdIndennizzo { get; set; }
        public decimal? ImpIndennizzo { get; set; }
        public decimal IdGaranziaassicurata { get; set; }
        public decimal? IdValuta { get; set; }
        public string FlgAssicuratoSino { get; set; }
        public decimal? IdRecupero { get; set; }
        public decimal? ImpRecupero { get; set; }
        public int? IdQuietanza { get; set; }
    }
}
