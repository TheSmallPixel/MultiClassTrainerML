using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PtfPremiEmessi
    {
        public PtfPremiEmessi()
        {
            PtfPremiEmessiGaranzie = new HashSet<PtfPremiEmessiGaranzie>();
        }

        public decimal IdPremioEmesso { get; set; }
        public decimal KeyTitTitolo { get; set; }
        public decimal IdTitTitolo { get; set; }
        public decimal IdPolizza { get; set; }
        public decimal IdCompagnia { get; set; }
        public decimal AnnoCompetenza { get; set; }
        public decimal MeseCompetenza { get; set; }
        public decimal IdTitTipoTitolo { get; set; }
        public string CodTipoTitolo { get; set; }
        public string FlgCategoriaEmesso { get; set; }
        public string NPolizza { get; set; }
        public DateTime DtEffetto { get; set; }
        public DateTime DtCopertura { get; set; }
        public decimal IdAgenzia { get; set; }
        public string CodAgenzia { get; set; }
        public decimal IdPrProdotto { get; set; }
        public string CodProdotto { get; set; }
        public decimal IdPrRamo { get; set; }
        public string CodRamo { get; set; }
        public decimal IdValuta { get; set; }
        public string CodValuta { get; set; }
        public decimal IdAnagrafica { get; set; }
        public string Contraente { get; set; }
        public decimal ImpNetto { get; set; }
        public decimal ImpAccessori { get; set; }
        public decimal ImpSsn { get; set; }
        public decimal ImpTasse { get; set; }
        public decimal ImpAntiracket { get; set; }
        public decimal? ImpGarAcquisto { get; set; }
        public decimal? ImpGarIncasso { get; set; }
        public decimal? ImpAccAcquisto { get; set; }
        public decimal? ImpAccIncasso { get; set; }
        public string FlgTipoCoass { get; set; }
        public decimal? PctQuota { get; set; }
        public string CompagniaCoass { get; set; }
        public DateTime? DtProdotto { get; set; }
        public decimal? IdSubagenzia { get; set; }
        public string CodSubagenzia { get; set; }
        public string CodFrazionamento { get; set; }

        public virtual ICollection<PtfPremiEmessiGaranzie> PtfPremiEmessiGaranzie { get; set; }
    }
}
