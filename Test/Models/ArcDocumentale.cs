using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcDocumentale
    {
        public int IdArcDocumentale { get; set; }
        public string RifEsterno { get; set; }
        public string FlgTipologiaDocumentale { get; set; }
        public string TipologiaDocumento { get; set; }
        public DateTime? DtInserimento { get; set; }
        public int? IdAllegato { get; set; }
        public string NomeDocumento { get; set; }
    }
}
