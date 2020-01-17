using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class StatGestRiepilogo
    {
        public int IdStatGestRiepilogo { get; set; }
        public string FlgTipoStatGest { get; set; }
        public DateTime DtRiferimento { get; set; }
        public string FlgStoricizMensileSino { get; set; }
        public int IdCompagnia { get; set; }
        public DateTime DtSysEstrazione { get; set; }
        public string FlgOndemandSino { get; set; }
    }
}
