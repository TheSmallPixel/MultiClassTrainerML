using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcMandatiAlboAgenti
    {
        public decimal KeyArcMandatoAlboAgenti { get; set; }
        public decimal IdArcMandatoAlboAgenti { get; set; }
        public decimal? IdCompagnia { get; set; }
        public decimal IdRetevendita { get; set; }
        public DateTime DtConferimentoMandato { get; set; }
        public string FlgTipoEsclusivaAlboAgenti { get; set; }
        public DateTime? DtRevocaMandato { get; set; }
        public string FlgMotRevMandAlboAgenti { get; set; }
        public string FlgTipoMandato { get; set; }
        public string CodMandato { get; set; }
        public DateTime? DtEffettoVariazione { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtAnzianitaGestione { get; set; }
    }
}
