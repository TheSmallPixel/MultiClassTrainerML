using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrDatiUbicazioni
    {
        public decimal KeyPrDatiUbicazione { get; set; }
        public decimal? IdPrDatiUbicazione { get; set; }
        public decimal? IdPrBene { get; set; }
        public string FlgRicAnnoSino { get; set; }
        public string FlgRicTipoFabbSino { get; set; }
        public string FlgRicTipoRipSino { get; set; }
        public string FlgRicAttivitaSino { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgRichiediValore { get; set; }
        public string FlgRichProprietariSino { get; set; }
        public string FlgProprietariObbSino { get; set; }
        public string FlgCodeAttivita { get; set; }
        public string FlgAbitPrincSino { get; set; }
        public string FlgGeolocalizzazioneSino { get; set; }
        public string FlgRichiestaVincolo { get; set; }
        public string FlgTipoFabbObbSino { get; set; }
        public string FlgTipoRipObbSino { get; set; }
        public string FlgTipoCalcoloValore { get; set; }
    }
}
