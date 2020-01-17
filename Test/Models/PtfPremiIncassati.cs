using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PtfPremiIncassati
    {
        public PtfPremiIncassati()
        {
            PtfPremiIncassatiGaranzie = new HashSet<PtfPremiIncassatiGaranzie>();
        }

        public decimal IdPremioIncassato { get; set; }
        public decimal KeyTitEsito { get; set; }
        public decimal IdTitEsito { get; set; }
        public decimal IdPolizza { get; set; }
        public decimal IdCompagnia { get; set; }
        public decimal AnnoCompetenza { get; set; }
        public decimal MeseCompetenza { get; set; }
        public decimal IdTitTipoTitolo { get; set; }
        public string CodTipoTitolo { get; set; }
        public string NPolizza { get; set; }
        public DateTime DtEffetto { get; set; }
        public DateTime DtCopertura { get; set; }
        public DateTime DtEsito { get; set; }
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
        public string FlgEsentasseSino { get; set; }
        public string FlgTipoEsito { get; set; }
        public decimal ImpNetto { get; set; }
        public decimal ImpAccessori { get; set; }
        public decimal ImpSsn { get; set; }
        public decimal ImpTasse { get; set; }
        public decimal ImpAntiracket { get; set; }
        public decimal ImpImponibileSoggetto { get; set; }
        public decimal ImpImponibileNonSoggetto { get; set; }
        public decimal ImpImponibileEsente { get; set; }
        public decimal? ImpGarAcquisto { get; set; }
        public decimal? ImpGarIncasso { get; set; }
        public decimal? ImpAccAcquisto { get; set; }
        public decimal? ImpAccIncasso { get; set; }
        public DateTime? DtSysEsito { get; set; }

        public virtual ICollection<PtfPremiIncassatiGaranzie> PtfPremiIncassatiGaranzie { get; set; }
    }
}
