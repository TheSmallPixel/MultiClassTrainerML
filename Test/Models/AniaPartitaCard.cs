using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaPartitaCard
    {
        public int KeyAniaPartitaCard { get; set; }
        public int IdAniaPartitaCard { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public int? IdAnagrafica { get; set; }
        public string FlgGestionarioDebitore { get; set; }
        public string FlgUltimoFlussoAccettSino { get; set; }
        public DateTime? DtPrimaPredisposizione { get; set; }
        public DateTime? DtPrimoInvio { get; set; }
        public DateTime? DtUltimoInvio { get; set; }
        public DateTime? DtPrimoOk { get; set; }
        public DateTime? DtUltimoOk { get; set; }
        public string RuoloPartita { get; set; }
        public string CodiceFiscalePartita { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
        public string FlgTipoCaricamento { get; set; }
        public DateTime? DtUltimaPredisposizione { get; set; }
        public string CognomeRagioneSociale { get; set; }
        public decimal? ImpIndennizziAntifrode { get; set; }
        public decimal? ImportoRecuperiAntifrode { get; set; }
        public int? IdAniaSinistroCard { get; set; }
        public string IdentificativoPartita { get; set; }
        public int? IdAniaPartitaCardDett { get; set; }
    }
}
