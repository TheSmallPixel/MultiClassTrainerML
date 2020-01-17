using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcDocumentaleApp
    {
        public int IdArcDocumentaleApp { get; set; }
        public int IdArcDocumentale { get; set; }
        public int IdOggetto { get; set; }
        public string FlgStatoInvioDocumento { get; set; }
        public string FlgTipoOggetto { get; set; }
        public DateTime? DtAppartenenza { get; set; }
        public int? IdUtenteAppartenenza { get; set; }
    }
}
