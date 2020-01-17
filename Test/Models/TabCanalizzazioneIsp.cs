using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabCanalizzazioneIsp
    {
        public int IdCanalizzazioneIsp { get; set; }
        public int IdCompagnia { get; set; }
        public DateTime DtInizioValidita { get; set; }
        public DateTime DtFineValidita { get; set; }
        public int? IdRetevendita { get; set; }
        public string FlgRamoTecnico { get; set; }
        public int? IdIspettorato { get; set; }
        public string FlgTipoSinistroCanaliz { get; set; }
        public int? IdProvincia { get; set; }
    }
}
