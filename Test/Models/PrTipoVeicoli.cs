using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrTipoVeicoli
    {
        public decimal KeyPrTipoVeicolo { get; set; }
        public decimal IdPrTipoVeicolo { get; set; }
        public decimal? IdPrDatiVeicolo { get; set; }
        public decimal IdSettore { get; set; }
        public decimal? IdClasse { get; set; }
        public decimal? IdUso { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgRichiestaTipoTarga { get; set; }
        public string FlgRichiestaTessera { get; set; }
        public string FlgRichiestaValore { get; set; }
        public string FlgRichiestaProprietario { get; set; }
        public string FlgRichiestaConducente { get; set; }
        public string FlgRichiestaTabVeicoli { get; set; }
        public string FlgRichiestaSoloTabella { get; set; }
        public string FlgRichiestaDescVeicolo { get; set; }
        public string FlgRichiestaAbrogazione { get; set; }
        public string FlgRichiestaOptional { get; set; }
        public string FlgRichiestaVincolo { get; set; }
        public string FlgRichiestaCartaVerde { get; set; }
        public string FlgMotivoAssicSino { get; set; }
        public string FlgRichiestaTargaTelaio { get; set; }
        public string FlgDerogaSino { get; set; }
        public decimal? CodDeroga { get; set; }
        public string FlgTipoValVeicolo { get; set; }

        public virtual TabClasse IdClasseNavigation { get; set; }
        public virtual TabSettore IdSettoreNavigation { get; set; }
        public virtual TabUso IdUsoNavigation { get; set; }
    }
}
