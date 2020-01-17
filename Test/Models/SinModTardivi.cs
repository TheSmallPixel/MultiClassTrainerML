using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinModTardivi
    {
        public int KeySinModTardivi { get; set; }
        public int? IdCompagnia { get; set; }
        public string AnnoCompetenza { get; set; }
        public string FlgCodTipoModulo { get; set; }
        public string FlgAllegato { get; set; }
        public string FlgRamoBilancio { get; set; }
        public string FlgTipoGestione { get; set; }
        public string AnnoAccadimento { get; set; }
        public decimal? RisInizNum { get; set; }
        public decimal? RisInizCosto { get; set; }
        public decimal? RisInizImporto { get; set; }
        public decimal? RisFinNum { get; set; }
        public decimal? RisFinCosto { get; set; }
        public decimal? RisFinImporto { get; set; }
    }
}
