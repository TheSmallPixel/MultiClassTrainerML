using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaTipoDocumentazione
    {
        public int IdAniaTipoDocumentazione { get; set; }
        public string FlgCodice { get; set; }
        public string DescrizioneSituazioneResp { get; set; }
        public int? NumeroAllegati { get; set; }
        public int? DimensioneMassimaKb { get; set; }
    }
}
