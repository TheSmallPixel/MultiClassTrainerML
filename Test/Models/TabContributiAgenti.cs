using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabContributiAgenti
    {
        public int KeyContributiagente { get; set; }
        public int IdContributiagente { get; set; }
        public int IdUtente { get; set; }
        public int IdCompagnia { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public DateTime DtEffetto { get; set; }
        public DateTime DtScadenza { get; set; }
        public string FlgProvenienzaSinistro { get; set; }
        public decimal? ImpProvenienzaSinistro { get; set; }
        public string FlgDenunciaAgenteSino { get; set; }
        public decimal? ImpDenunciaAgente { get; set; }
        public string FlgTipologiaSinistro { get; set; }
        public decimal? ImpTipologiaSinistro { get; set; }
        public string FlgDatiCompletiSino { get; set; }
        public decimal? ImpDatiCompleti { get; set; }
        public int GiorniMaxCodifica { get; set; }
        public string FlgCodificaEntroGgMaxSino { get; set; }
        public decimal? ImpCodificaEntroGgMax { get; set; }
        public string FlgCoinvolgimentoLegaleSino { get; set; }
        public decimal? ImpCoinvolgimentoLegale { get; set; }
    }
}
