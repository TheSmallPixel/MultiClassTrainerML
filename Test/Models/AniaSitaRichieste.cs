using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaSitaRichieste
    {
        public int IdRichiestaSita { get; set; }
        public int? IdRichiestaIbd { get; set; }
        public DateTime DtRiferimentoRichiesta { get; set; }
        public string FlgEsitoElaborazione { get; set; }
        public string FlgTipoTargaAlternativo { get; set; }
        public string IdentVeicoloAlternativo { get; set; }
        public string FlgTipoVeicolo { get; set; }
        public string CodiceImpresa { get; set; }
        public DateTime? DtEffettoCopertura { get; set; }
        public DateTime? DtScadenzaCopertura { get; set; }
        public string FlgTipoMovimento { get; set; }
        public string FlgTipoCausale { get; set; }
        public string CodFiscaleContraente { get; set; }
        public string CodFiscaleProprietario { get; set; }
        public string NumeroPolizza { get; set; }
        public DateTime? DtEffettoPolizza { get; set; }
        public DateTime? DtScadenzaPolizza { get; set; }
        public string FlgTipoTariffa { get; set; }
        public string FlgTipoPolizza { get; set; }
        public string FlgBlackBoxPresenteSino { get; set; }
        public DateTime? DtElabAnia { get; set; }
        public string FlgTacitoRinnovoSino { get; set; }
        public string GiorniEstensioneCopertura { get; set; }
        public string OraEffettoCopertura { get; set; }
        public string FlgControlloIdentVeic { get; set; }
        public DateTime? DtIncasso { get; set; }
        public string FlgModalitaPagamento { get; set; }
        public DateTime? DtScadenzaSospensione { get; set; }
        public string FlgDatiCompleti { get; set; }
        public DateTime? DtScadenzaMora { get; set; }
        public string OraScadenzaCopertura { get; set; }
        public string ProtocolloAnia { get; set; }
        public string UserUltimoAgg { get; set; }
        public string FlgCanaleUltimoAgg { get; set; }
        public string TimeUltimoAgg { get; set; }
        public string RifRichiestaUltimoAgg { get; set; }
        public string RifRichiedenteUltimoAgg { get; set; }
        public DateTime? DtUltimoAggiornamento { get; set; }
        public string FlgTipoVeicoloMctc { get; set; }
        public string CodiceIur { get; set; }
    }
}
