using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaRespCard
    {
        public int KeyAniaRespCard { get; set; }
        public int IdAniaRespCard { get; set; }
        public int? IdSinistro { get; set; }
        public string FlgTipoMittente { get; set; }
        public DateTime? DtPrimaPredisposizione { get; set; }
        public DateTime? DtUltimaPredisposizione { get; set; }
        public DateTime? DtPrimoInvio { get; set; }
        public DateTime? DtUltimoInvio { get; set; }
        public DateTime? DtPrimoOk { get; set; }
        public DateTime? DtUltimoOk { get; set; }
        public string FlgUltimoFlussoAccettSino { get; set; }
        public string FlgTipoCaricamento { get; set; }
        public string FlgRagioneTorto { get; set; }
        public string FlgTipoFirma { get; set; }
        public int? IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdAniaSinistroCard { get; set; }
        public int? IdAniaSituazioneRespDett { get; set; }
    }
}
