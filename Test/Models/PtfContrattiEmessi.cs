using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PtfContrattiEmessi
    {
        public decimal IdContrattoEmesso { get; set; }
        public decimal KeyPolEvento { get; set; }
        public decimal IdCompagnia { get; set; }
        public decimal AnnoCompetenza { get; set; }
        public decimal MeseCompetenza { get; set; }
        public string FlgTipoEmesso { get; set; }
        public DateTime DtRegistrazione { get; set; }
        public string NPolizza { get; set; }
        public string CodAgenzia { get; set; }
        public decimal IdAgenzia { get; set; }
        public decimal IdPrRamo { get; set; }
        public string CodRamo { get; set; }
        public decimal IdPrProdotto { get; set; }
        public string CodProdotto { get; set; }
        public DateTime DtEffetto { get; set; }
        public string FlgTipoEvento { get; set; }
        public string FlgTipoEventoStornato { get; set; }
        public decimal IdAnagrafica { get; set; }
        public string Contraente { get; set; }
        public decimal IdValuta { get; set; }
        public string CodValuta { get; set; }
    }
}
