using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaRiepilogoRivalseCtt
    {
        public int IdAniaRiepRivalsaCtt { get; set; }
        public string CodImpresa { get; set; }
        public DateTime? DtStanzaRiferimento { get; set; }
        public int? NumPagRicorrDel { get; set; }
        public int? NumStorniRicorrDel { get; set; }
        public decimal? ImpCttRicorrDel { get; set; }
        public int? NumPagControintDel { get; set; }
        public int? NumStorniControintDel { get; set; }
        public decimal? ImpCttControintDel { get; set; }
        public decimal? ImpASaldoDel { get; set; }
        public int? NumPagRicorrAl { get; set; }
        public int? NumStorniRicorrAl { get; set; }
        public decimal? ImpCttRicorrAl { get; set; }
        public int? NumPagControintAl { get; set; }
        public int? NumStorniControintAl { get; set; }
        public decimal? ImpCttControintAl { get; set; }
        public decimal? ImpASaldoAl { get; set; }
    }
}
