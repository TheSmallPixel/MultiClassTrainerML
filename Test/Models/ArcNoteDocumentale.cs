using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcNoteDocumentale
    {
        public int IdNoteDocumentale { get; set; }
        public int IdDatiAggDocumentale { get; set; }
        public int? IdUtente { get; set; }
        public string Note { get; set; }
        public DateTime? DataInserimento { get; set; }
    }
}
