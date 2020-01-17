using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AppoPol4
    {
        public decimal IdPolizza { get; set; }
        public string CodCompagnia { get; set; }
        public string CodAgenzia { get; set; }
        public string CodSubagenzia { get; set; }
        public string CodProduttore { get; set; }
        public string CodProduttore4 { get; set; }
        public string CodRamo { get; set; }
        public string CodProdotto { get; set; }
        public string TipoCedente { get; set; }
        public string TipoTariffa { get; set; }
        public string NPolizza { get; set; }
        public string NProposta { get; set; }
        public string NPratica { get; set; }
        public DateTime? DtEffetto { get; set; }
        public string HhmmEffetto { get; set; }
        public DateTime? DtEmissione { get; set; }
        public DateTime? DtScadenzaOrig { get; set; }
        public DateTime? DtEffettoRata { get; set; }
        public DateTime? DtScadenzaRata { get; set; }
        public DateTime? DtScadenzaPolizza { get; set; }
        public string FlgDurata { get; set; }
        public string CodFraz { get; set; }
        public string FlgTacRinnovoSino { get; set; }
        public string FlgTipoCoass { get; set; }
        public decimal PctAccessori { get; set; }
        public decimal? ImpAccessori { get; set; }
        public decimal? ImpNetto { get; set; }
        public decimal? ImpSsn { get; set; }
        public decimal? ImpTasse { get; set; }
        public string FlgRamoBilancio { get; set; }
        public decimal? IdPolStato { get; set; }
        public string TipoProdotto { get; set; }
        public string FlgAppartenenzaRete { get; set; }
        public string FascicoloInformativo { get; set; }
        public string AbbinataFinanziamento { get; set; }
        public string CodAgenziaFirma { get; set; }
        public string CodSubagenziaFirma { get; set; }
        public string CodProduttoreFirma { get; set; }
        public string CodProduttore4Firma { get; set; }
    }
}
