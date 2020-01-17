using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcDestDossierRete
    {
        public int IdDestDossierRete { get; set; }
        public int IdDossierRete { get; set; }
        public int IdAnagrafica { get; set; }
        public string FlgTipoDestinatarioDoc { get; set; }
        public string IndirizzoEmail { get; set; }
        public string FlgTipoDocumentoMail { get; set; }
    }
}
