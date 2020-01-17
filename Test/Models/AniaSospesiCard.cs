using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaSospesiCard
    {
        public int IdSospesoCard { get; set; }
        public DateTime DtAvvenimento { get; set; }
        public string TargaInv { get; set; }
        public string TargaRic { get; set; }
        public string RecordRic { get; set; }
        public string CodAniaCompInv { get; set; }
        public string CodAniaCompRic { get; set; }
        public string FlgTipoRecord { get; set; }
        public DateTime? DtFlussoRic { get; set; }
        public int? Progressivo { get; set; }
        public string CodErrore { get; set; }
        public string NomeFile { get; set; }
        public string NomeFlusso { get; set; }
        public string FlgStato { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public string FlgIgnoraForfaitSino { get; set; }
        public string FlgCausaleStato { get; set; }
    }
}
