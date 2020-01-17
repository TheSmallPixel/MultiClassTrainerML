using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabParametriOperazioni
    {
        public decimal KeyTabParametriOperazione { get; set; }
        public decimal IdTabParametriOperazione { get; set; }
        public decimal IdCompagnia { get; set; }
        public decimal IdTabOperazione { get; set; }
        public decimal IdDescrizione { get; set; }
        public string FlgAutorizzazioneSino { get; set; }
        public string FlgEmissioneRetroattivaSino { get; set; }
        public string FlgGeneraTitoloZeroSino { get; set; }
        public string FlgIncassoTitoloZeroSino { get; set; }
        public decimal? IdTitTipoTitolo { get; set; }
        public string FlgDefaultSino { get; set; }
        public decimal IdUtente { get; set; }
        public decimal? IdOperazione { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string Descrizione { get; set; }
        public int? NGgEmisPostergata { get; set; }
        public int? NGgEmisAntergata { get; set; }
        public decimal? CodDeroga { get; set; }
        public string FlgBloccoSeTitInsSino { get; set; }
        public int? NumGgScostEffPol { get; set; }
        public string FlgDerogaScostEffPolSino { get; set; }
        public int? CodDerogaScostEffPol { get; set; }

        public virtual TabOperazioni IdOperazioneNavigation { get; set; }
    }
}
