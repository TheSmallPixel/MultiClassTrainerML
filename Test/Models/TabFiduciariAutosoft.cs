using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabFiduciariAutosoft
    {
        public int IdFiduciarioAutosoft { get; set; }
        public int IdFiduciario { get; set; }
        public string FlgEsenteIvaSino { get; set; }
        public decimal? PercIva { get; set; }
        public string FlgRitSuCassaSino { get; set; }
        public decimal? PercRitAcconto { get; set; }
        public decimal? PercContrInps { get; set; }
        public decimal? PercCassa { get; set; }
        public int? NumMaxParcelleFatt { get; set; }
        public string DescEsenzioneIva { get; set; }
        public string FlgFatturazioneSino { get; set; }
    }
}
