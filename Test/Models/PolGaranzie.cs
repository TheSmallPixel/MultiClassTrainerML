using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolGaranzie
    {
        public PolGaranzie()
        {
            PolGaranzieRegolate = new HashSet<PolGaranzieRegolate>();
        }

        public decimal KeyPolGaranzia { get; set; }
        public decimal? IdPolizza { get; set; }
        public decimal? IdPolGaranzia { get; set; }
        public decimal? IdPolBene { get; set; }
        public decimal? IdPrGaranzia { get; set; }
        public decimal? IdPrGarTariffa { get; set; }
        public DateTime? DtTariffaOriginale { get; set; }
        public decimal? ImpNetto { get; set; }
        public decimal? ImpAccessori { get; set; }
        public decimal? ImpTasse { get; set; }
        public decimal? ImpSsn { get; set; }
        public decimal? ImpAntiracket { get; set; }
        public decimal? ImpNettoAnnuo { get; set; }
        public decimal? ImpAccessoriAnnuo { get; set; }
        public decimal? ImpTasseAnnuo { get; set; }
        public decimal? ImpSsnAnnuo { get; set; }
        public decimal? PctTasse { get; set; }
        public decimal? PctAntiracket { get; set; }
        public decimal? PctSsn { get; set; }
        public decimal? PctFvs { get; set; }
        public decimal? ImpFranchigia { get; set; }
        public decimal? PctScoperto { get; set; }
        public decimal? ImpMaxScoperto { get; set; }
        public decimal? Tasso { get; set; }
        public decimal? ImpCapitale1 { get; set; }
        public decimal? ImpCapitale2 { get; set; }
        public decimal? ImpMaxSinistro { get; set; }
        public decimal? ImpMaxPersone { get; set; }
        public decimal? ImpMaxCose { get; set; }
        public decimal? ImpMaxInterruzione { get; set; }
        public decimal? NAddetti { get; set; }
        public string Note { get; set; }
        public decimal IdUtente { get; set; }
        public decimal? NrQuote { get; set; }
        public decimal? PctVariazionePremio { get; set; }
        public decimal? PctVariazionePremioFirma { get; set; }
        public decimal? IdValutaFranchigia { get; set; }
        public decimal? IdValutaCapitale1 { get; set; }
        public decimal? IdValutaCapitale2 { get; set; }
        public decimal? IdValutaMaxSinistro { get; set; }
        public decimal? IdValutaMaxPersone { get; set; }
        public decimal? IdValutaMaxCose { get; set; }
        public decimal? IdValutaMaxInterruzione { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public DateTime? DtTentataVendita { get; set; }
        public decimal? ImpNettoOperazione { get; set; }
        public decimal? ImpTasseOperazione { get; set; }
        public decimal? ImpSsnOperazione { get; set; }
        public decimal? ImpAccessoriOperazione { get; set; }
        public decimal? ImpDetraibile { get; set; }
        public int? IdPrPacchetto { get; set; }
        public DateTime? DtScadenzaGaranzia { get; set; }
        public decimal? ImpCapitale1Originale { get; set; }
        public string FlgPrMinForzNoScontoSino { get; set; }
        public decimal? ImpFranchigiaAggAnnuo { get; set; }
        public decimal? ImpFranchigiaAgg { get; set; }
        public string FlgTipoAbbatSconto { get; set; }
        public decimal? PctVarPremioFirmaOrig { get; set; }
        public decimal? PctVarPremioOrig { get; set; }
        public decimal? ImpPremioFormula { get; set; }
        public decimal? ImpScontabileRinnovo { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
        public virtual ICollection<PolGaranzieRegolate> PolGaranzieRegolate { get; set; }
    }
}
