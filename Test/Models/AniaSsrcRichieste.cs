using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaSsrcRichieste
    {
        public int IdRichiestaSsrc { get; set; }
        public int? IdRichiestaIbd { get; set; }
        public DateTime DtRiferimentoRichiesta { get; set; }
        public string FlgEsitoElaborazione { get; set; }
        public string FlgTipoVeicoloRichiesta { get; set; }
        public DateTime? DtAccadimentoSinistro { get; set; }
        public string CodiceImpresaDenunciante { get; set; }
        public string FlgTipoVeicoloDenunciante { get; set; }
        public string TargaVeicoloDenunciante { get; set; }
        public string FlgTipoVeicoloControparte { get; set; }
        public string TargaVeicoloControparte { get; set; }
        public string NumeroSinistroDenunciante { get; set; }
        public string FlgTipoCidParzialeTotale { get; set; }
        public string CodiceImpresaDebitrice { get; set; }
        public DateTime? DtInserimentoSinistro { get; set; }
        public string FlgRuoloVeicolo { get; set; }
    }
}
