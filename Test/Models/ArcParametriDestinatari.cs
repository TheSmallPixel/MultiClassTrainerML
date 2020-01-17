using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcParametriDestinatari
    {
        public int KeyParametroDestinatario { get; set; }
        public int IdParametroDestinatario { get; set; }
        public int? IdIndirizzo { get; set; }
        public int? IdRecapito { get; set; }
        public int? IdAnagrafica { get; set; }
        public int? IdParametroStampa { get; set; }
        public string FlgSistemaPostalizzazione { get; set; }
        public string FlgTipoPostalizzazione { get; set; }
        public string Note { get; set; }
        public DateTime? DtCreazione { get; set; }
        public string Nominativo { get; set; }
        public int? IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgTipoInvioStampa { get; set; }
    }
}
