using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CntRendiconti
    {
        public decimal KeyCntRendiconto { get; set; }
        public decimal? IdCntRendiconto { get; set; }
        public decimal? IdAgenzia { get; set; }
        public DateTime? DtRendiconto { get; set; }
        public decimal? NRendiconto { get; set; }
        public decimal? ImpTitPremio { get; set; }
        public decimal? ImpTitProvvigioni { get; set; }
        public decimal? ImpPvDare { get; set; }
        public decimal? ImpPvAvere { get; set; }
        public decimal? ImpFrancRecuperata { get; set; }
        public decimal? ImpFrancProvvigioni { get; set; }
        public decimal? ImpSinPagato { get; set; }
        public decimal? ImpSinProvvigioni { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal IdCompagnia { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdValuta { get; set; }
        public int? IdCcAgenzia { get; set; }
        public int? IdCcSeparato { get; set; }
    }
}
