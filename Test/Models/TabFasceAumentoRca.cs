using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabFasceAumentoRca
    {
        public int IdFasciaAumento { get; set; }
        public string FlgTipoAbbScRca { get; set; }
        public decimal? PctScontoDa { get; set; }
        public decimal? PctScontoA { get; set; }
        public decimal? PctAumentoRca { get; set; }
    }
}
