using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabCombinazioniCasiCid
    {
        public int IdCombinazioneCasiCid { get; set; }
        public int IdCasoCidComp { get; set; }
        public int IdCasoCidCtp { get; set; }
        public decimal? PercResp { get; set; }
        public decimal? PercRespForzatura { get; set; }
    }
}
