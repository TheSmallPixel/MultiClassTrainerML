using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CntFoglicassa
    {
        public decimal KeyCntFogliocassa { get; set; }
        public decimal? IdCntFogliocassa { get; set; }
        public decimal? IdAgenzia { get; set; }
        public decimal? NFogliocassa { get; set; }
        public DateTime? DtFogliocassa { get; set; }
        public decimal? IdCntRendiconto { get; set; }
        public decimal? ImpTitPremio { get; set; }
        public decimal? ImpTitProvvigioni { get; set; }
        public decimal? ImpPvDare { get; set; }
        public decimal? ImpPvAvere { get; set; }
        public decimal? ImpRecuperati { get; set; }
        public decimal? ImpProvvigioniRecuperi { get; set; }
        public decimal? ImpIndennizzi { get; set; }
        public decimal? ImpProvvigioniIndennizzi { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal? ImpARiportareDare { get; set; }
        public decimal? ImpARiportareAvere { get; set; }
        public decimal? IdCompagnia { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdValuta { get; set; }
        public string RifEsterno { get; set; }
    }
}
