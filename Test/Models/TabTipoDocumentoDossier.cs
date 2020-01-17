using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabTipoDocumentoDossier
    {
        public TabTipoDocumentoDossier()
        {
            ArcDossierRete = new HashSet<ArcDossierRete>();
        }

        public int IdTipoDocumentoDossier { get; set; }
        public string FlgTipoEntita { get; set; }
        public string CodTipoDocumentoDossier { get; set; }
        public int IdDescrizione { get; set; }
        public string FlgDaArchiviareSino { get; set; }
        public int? IdModello { get; set; }
        public int? IdCausale { get; set; }
        public DateTime DtIniVal { get; set; }
        public DateTime DtFinVal { get; set; }
        public string OggettoMail { get; set; }
        public string CorpoMail { get; set; }
        public string Descrizione { get; set; }
        public string FlgCcAgenziaSino { get; set; }
        public string FlgDestRespCommSino { get; set; }
        public string FlgCcRespCommSino { get; set; }
        public string FlgDestDipartimentoSino { get; set; }
        public string FlgCcDipartimentoSino { get; set; }
        public string FlgDestCapoAreaSino { get; set; }
        public string FlgCcCapoAreaSino { get; set; }
        public string FlgDestDp2Sino { get; set; }
        public string FlgCcDp2Sino { get; set; }
        public string FlgDestCaaSino { get; set; }
        public string FlgCcCaaSino { get; set; }
        public string FlgDestP3Sino { get; set; }
        public string FlgCcP3Sino { get; set; }
        public string FlgDestRespTerrSino { get; set; }
        public string FlgCcRespTerrSino { get; set; }
        public string FlgDestAgenziaSino { get; set; }
        public string IndirizzoEmailMittente { get; set; }
        public string FlgPresenzaAltriNodiSino { get; set; }
        public string FlgAgenziaErogazioneSino { get; set; }
        public string FlgQualificaLivCarriera { get; set; }
        public int? IdLivelloCarriera { get; set; }
        public int? IdAllegato { get; set; }
        public string FlgContestGenericoSino { get; set; }
        public string FlgDestCoordReteDedSino { get; set; }
        public string FlgCcCoordReteDedSino { get; set; }

        public virtual TabCausaliRete IdCausaleNavigation { get; set; }
        public virtual ICollection<ArcDossierRete> ArcDossierRete { get; set; }
    }
}
