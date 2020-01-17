using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaSinistriCardRichieste
    {
        public int IdRichiestaCard { get; set; }
        public int? IdRichiestaIbd { get; set; }
        public DateTime DtRiferimentoRichiesta { get; set; }
        public string FlgEsitoElaborazione { get; set; }
        public string FlgTipoVeicoloRichiesta { get; set; }
        public string CodiceImpresaGestionaria { get; set; }
        public string FlgTipoTargaGestionaria { get; set; }
        public string TargaGestionaria { get; set; }
        public string CodiceImpresaDebitrice { get; set; }
        public string FlgTipoTargaDebitrice { get; set; }
        public string TargaDebitrice { get; set; }
        public DateTime? DtAccadimentoSinistro { get; set; }
        public string FlgTipoVeicoloGestionaria { get; set; }
        public string FlgTipoVeicoloDebitrice { get; set; }
        public string NumeroSinistroDenunciante { get; set; }
        public string RuoloVeicoloRichiesto { get; set; }
        public DateTime? DtAggiornamentoSinistro { get; set; }
        public DateTime? DtStanza { get; set; }
        public string FlgStatoPagamento { get; set; }
    }
}
