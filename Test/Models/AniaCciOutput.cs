using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaCciOutput
    {
        public decimal IdAniaCciOutput { get; set; }
        public DateTime? DtInvio { get; set; }
        public decimal? Progressivo { get; set; }
        public decimal? IdCompagnia { get; set; }
        public string NomeFile { get; set; }
        public string FlgProvvisorioSino { get; set; }
        public string FlgRcaInf { get; set; }
        public int IdUtente { get; set; }
        public DateTime? DtEvento { get; set; }
        public DateTime? DtPagamentoDa { get; set; }
        public DateTime? DtPagamentoA { get; set; }
        public DateTime? DtEstrazioneAl { get; set; }
    }
}
