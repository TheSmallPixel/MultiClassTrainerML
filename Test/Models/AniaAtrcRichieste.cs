using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaAtrcRichieste
    {
        public int IdRichiestaAtrc { get; set; }
        public int? IdRichiestaIbd { get; set; }
        public DateTime DtRiferimentoRichiesta { get; set; }
        public string FlgEsitoElaborazione { get; set; }
        public DateTime? DtScadenzaContratto { get; set; }
        public string FlgTipoMovimento { get; set; }
        public string FlgTipoCausale { get; set; }
        public string CodFiscaleContraente { get; set; }
        public string CodiceLegge { get; set; }
        public string NumeroPolizza { get; set; }
        public string FlgTipoTariffa { get; set; }
        public int? NumFrancNoCorrisposte { get; set; }
        public decimal? ImpFrancNoCorrisposte { get; set; }
        public string ClasseImpresaDa { get; set; }
        public string ClasseImpresaA { get; set; }
        public string ClasseCuDa { get; set; }
        public string ClasseCuA { get; set; }
        public DateTime? DtElabAnia { get; set; }
        public string CognomeRagSocialeContraente { get; set; }
        public string NomeContraente { get; set; }
        public string FlgTipoVeicolo { get; set; }
        public string CodiceImpresa { get; set; }
        public string CodFiscaleAventeDiritto { get; set; }
        public string CogRagSocAventeDiritto { get; set; }
        public string NomeAventeDiritto { get; set; }
        public string TipoAventeDiritto { get; set; }
        public string NaturaAventeDiritto { get; set; }
        public string Canale { get; set; }
        public string FlgTipoMovimentoAgg { get; set; }
        public string FlgTipoCausaleAgg { get; set; }
        public string FlgPolizzaGratuita { get; set; }
        public DateTime? DtFlussoIns { get; set; }
        public DateTime? DtFlussoAgg { get; set; }
        public string TimestampIns { get; set; }
        public string TimestampAgg { get; set; }
        public string FlgTipoPolizza { get; set; }
        public string CodiceIur { get; set; }
    }
}
