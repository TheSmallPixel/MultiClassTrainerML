using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabImportiPrevPrest
    {
        public int IdImportoPrevPrest { get; set; }
        public decimal ImpCostoMedio { get; set; }
        public DateTime DataInizioValidita { get; set; }
        public DateTime DataFineValidita { get; set; }
        public int IdValuta { get; set; }
        public int? IdPrestazione { get; set; }
        public string FlgTipoCardCompagnia { get; set; }
        public string FlgLdaSino { get; set; }
        public string FlgUtilizzaPercRespSino { get; set; }
    }
}
