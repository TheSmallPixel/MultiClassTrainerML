using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class BdiRilievi
    {
        public int IdRilievo { get; set; }
        public int? IdEstrazione { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdEntitaCoinvolta { get; set; }
        public int? IdIspettorato { get; set; }
        public string FlgStatoSinistro { get; set; }
        public DateTime? DtStatoSinistro { get; set; }
        public string CodErroreIsvap { get; set; }
        public string FlgInviatoSino { get; set; }
        public int? IdEntitaInviata { get; set; }
        public string FlgTipoEntitaInviata { get; set; }
        public string NSinistro { get; set; }
        public string CodIspettorato { get; set; }
        public int? IdCompagnia { get; set; }
        public DateTime? DtRilievo { get; set; }
        public DateTime? DtInvioIsvap { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
        public int KeyRilievo { get; set; }
        public string FlgStatoLavorazione { get; set; }
        public DateTime? DtStatoLavorazione { get; set; }
        public DateTime? DtRitornoIsvap { get; set; }
        public DateTime? DtRegSinistro { get; set; }
        public string FlgTipoOggettoRilievo { get; set; }
        public int? IdOggettoRilievo { get; set; }
        public DateTime? DtLavorazioneRilievo { get; set; }
        public int? IdUtenteLavorazioneRilievo { get; set; }
        public string FlgStatoRilievo { get; set; }
        public string NominativoRif { get; set; }
        public string CodFiscaleRif { get; set; }
        public string PartitaIvaRif { get; set; }
        public string TargaRif { get; set; }
        public string FlgSanzionabileSino { get; set; }
        public string FlgRichDatiInviataSino { get; set; }
    }
}
