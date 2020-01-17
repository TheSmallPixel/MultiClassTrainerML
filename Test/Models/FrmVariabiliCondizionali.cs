using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class FrmVariabiliCondizionali
    {
        public int KeyFrmVariabiliCondizionali { get; set; }
        public int IdFrmVariabiliCondizionali { get; set; }
        public int? IdFrmElencoValori { get; set; }
        public int? IdFrmVariabile { get; set; }
        public int? IdFrmGruppoVariabili { get; set; }
        public string NomeVariabileCondizionale { get; set; }
        public string FlgTipoOggetto { get; set; }
        public string FlgTipoEntitaVar { get; set; }
        public string FlgVisibilitaSino { get; set; }
        public string FlgValidazioneSino { get; set; }
        public string FlgValorizzazioneSino { get; set; }
        public int? IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
