using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcDeroghe
    {
        public int IdDeroga { get; set; }
        public string FlgModulo { get; set; }
        public string FlgTipoAzione { get; set; }
        public DateTime DtRichiesta { get; set; }
        public int IdUtenteRichiesta { get; set; }
        public string FlgStatoDeroga { get; set; }
        public int IdOggetto { get; set; }
        public DateTime DtStato { get; set; }
        public int? IdUtenteAssegnata { get; set; }
        public string XmlAzione { get; set; }
        public string Note { get; set; }
        public int? IdIspettorato { get; set; }
        public int? IdGruppo { get; set; }
        public string InfoDeroga { get; set; }
        public string FlgTipoOggetto { get; set; }
        public string FlgTipologiaDeroga { get; set; }
        public string FlgEscalationParzialeSino { get; set; }
    }
}
