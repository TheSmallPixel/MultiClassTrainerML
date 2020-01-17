using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabImportiPrev
    {
        public decimal IdImportoPrev { get; set; }
        public string CodParametri { get; set; }
        public decimal ImpCostoMedio { get; set; }
        public DateTime DataInizioValidita { get; set; }
        public DateTime DataFineValidita { get; set; }
        public decimal IdValuta { get; set; }
        public decimal? IdGaranzia { get; set; }
        public decimal? IdDescrizione { get; set; }
        public string Descrizione { get; set; }
    }
}
