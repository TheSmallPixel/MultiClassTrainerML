using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaPartitaCardDett
    {
        public int IdAniaPartitaCardDett { get; set; }
        public int IdAniaPartitaCard { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public int? IdFlussoCard { get; set; }
        public string FlgGestionarioDebitore { get; set; }
        public string FlgScartatoSino { get; set; }
        public DateTime? DtInvio { get; set; }
        public string IdentificativoPartita { get; set; }
        public string RuoloPartita { get; set; }
        public string NominativoPartita { get; set; }
        public string CodiceFiscalePartita { get; set; }
        public string ADisposizioneGestionaria { get; set; }
        public DateTime? DtElaborazioneAnia { get; set; }
        public int? PrgMovimentoAnia { get; set; }
        public string FlgTipoCaricamento { get; set; }
        public int? IdSospesoCard { get; set; }
    }
}
