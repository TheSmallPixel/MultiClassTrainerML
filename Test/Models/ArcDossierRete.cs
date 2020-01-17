using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcDossierRete
    {
        public int IdDossierRete { get; set; }
        public string CodRiferimento { get; set; }
        public DateTime? DtDocumento { get; set; }
        public DateTime? DtInserimento { get; set; }
        public string FlgStatoDocDossier { get; set; }
        public string Note { get; set; }
        public int IdTipoDocumentoDossier { get; set; }
        public int? IdAllegato { get; set; }
        public int? IdRetevendita { get; set; }
        public int? IdRuoloRete { get; set; }
        public int? IdP3DatiGenerali { get; set; }
        public string OggettoMail { get; set; }
        public string CorpoMail { get; set; }
        public string FlgArchivioExtSino { get; set; }
        public string FlgAutomaticoSino { get; set; }
        public string IndirizzoEmailMittente { get; set; }
        public int? IdOggetto { get; set; }
        public string FlgTipoCausale { get; set; }

        public virtual TabTipoDocumentoDossier IdTipoDocumentoDossierNavigation { get; set; }
    }
}
