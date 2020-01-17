using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class FrmVariabiliEntita
    {
        public int KeyFrmVariabileEntita { get; set; }
        public int IdFrmVariabileEntita { get; set; }
        public int IdOggetto { get; set; }
        public string FlgTipoOggetto { get; set; }
        public int? IdUtente { get; set; }
        public int? IdFrmGruppoVariabili { get; set; }
        public int? Ordine { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgPosRichiesta { get; set; }
    }
}
