using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RispostaSicPosAss
    {
        public int IdPosAssicurativaSic { get; set; }
        public int? IdRispostaSic { get; set; }
        public int? CodiceCompagnia { get; set; }
        public string Settore { get; set; }
        public string Classe { get; set; }
        public string Uso { get; set; }
        public string TipoComunicazione { get; set; }
        public DateTime? DataEffetto { get; set; }
        public DateTime? DataScadenza { get; set; }
        public string FlagUtilizzo { get; set; }
        public string FlagCopertura { get; set; }
        public string CodiceComunicazione { get; set; }
        public string CodiceCausale { get; set; }
        public string FlgMandatarioDebitore { get; set; }
    }
}
