using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class StoUtenti
    {
        public int IdUtente { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public int IdAnagrafica { get; set; }
        public DateTime? DtInizioValidita { get; set; }
        public DateTime? DtFineValidita { get; set; }
        public int IdLingua { get; set; }
        public DateTime? DtUltimaLogin { get; set; }
        public int? NumeroTentativiLogin { get; set; }
        public int? NumeroMinutiScaAccErr { get; set; }
        public string FlgAccountDisabilitatoSino { get; set; }
        public DateTime DtUltimaImpostazionePwd { get; set; }
        public string FlgTipoRuoloUtente { get; set; }
        public int IdAppartenenza { get; set; }
        public int? NumeroTentativiErrati { get; set; }
        public DateTime? DtLoginErrata { get; set; }
        public string FlgLetturaFacDgSino { get; set; }
        public string FlgCanaleEmissione { get; set; }
        public int IdStoricoUtente { get; set; }
        public string DtStorico { get; set; }
        public string FlgCancellatoSino { get; set; }
        public string FlgInibisciCambioPwdSino { get; set; }
        public string RiferimentoSso { get; set; }
    }
}
