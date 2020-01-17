using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaFlussiCard
    {
        public int IdFlussoCard { get; set; }
        public DateTime? DtFlussoInv { get; set; }
        public DateTime? DtFlussoRic { get; set; }
        public int IdSinistro { get; set; }
        public int? IdEntitaCoinvolta { get; set; }
        public DateTime? DtAbbinamento { get; set; }
        public string CodAniaCompInv { get; set; }
        public string CodAniaCompRic { get; set; }
        public string TargaInv { get; set; }
        public string TargaRic { get; set; }
        public DateTime DtAvvenimento { get; set; }
        public string FlgTipoRecord { get; set; }
        public string FlgErroreSino { get; set; }
        public string RecordInv { get; set; }
        public string RecordRic { get; set; }
        public int? IdIndennizzo { get; set; }
        public string NomeFlusso { get; set; }
        public string FlgNomeFlusso { get; set; }
        public string FlgIgnoraForfaitSino { get; set; }
        public string FlgCausaleStatoSospeso { get; set; }
        public int? IdSpesa { get; set; }
    }
}
