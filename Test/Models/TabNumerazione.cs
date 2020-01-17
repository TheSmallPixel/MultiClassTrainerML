using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabNumerazione
    {
        public decimal IdNumerazione { get; set; }
        public decimal ProgressivoNumerazione { get; set; }
        public decimal? IdRetevendita { get; set; }
        public decimal? IdIspettorato { get; set; }
        public decimal AnnoEsercizio { get; set; }
        public decimal IdCompagnia { get; set; }
        public string FlgTipoNumerazione { get; set; }
    }
}
