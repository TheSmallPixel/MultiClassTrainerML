using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaIniziative
    {
        public int IdIniziativaReteVendita { get; set; }
        public int IdRetevendita { get; set; }
        public int IdIniziativaRete { get; set; }
        public int IdCausale { get; set; }
        public DateTime? DtAdesione { get; set; }
        public DateTime? DtRinuncia { get; set; }
        public string NoteAdesione { get; set; }
        public string NoteRinuncia { get; set; }
        public string FlgPrevedeAnticipiSino { get; set; }
        public string FlgAdesioniFormaliSino { get; set; }
        public DateTime? DtAdesioneFormale { get; set; }

        public virtual TabCausaliRete IdCausaleNavigation { get; set; }
        public virtual TabIniziativeRete IdIniziativaReteNavigation { get; set; }
    }
}
