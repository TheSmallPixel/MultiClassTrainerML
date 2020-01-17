using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class FrmVarDinamiche
    {
        public int KeyFrmVarDinamica { get; set; }
        public int? IdFrmVarDinamica { get; set; }
        public string FlgTipoOggetto { get; set; }
        public int IdOggetto { get; set; }
        public int? IdElencoValore { get; set; }
        public string ValoreStringa { get; set; }
        public decimal? ValoreNumerico { get; set; }
        public DateTime? ValoreData { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
