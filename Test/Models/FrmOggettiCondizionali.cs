using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class FrmOggettiCondizionali
    {
        public int KeyFrmOggettiCondizionali { get; set; }
        public int IdFrmOggettiCondizionali { get; set; }
        public int IdFrmGruppoVariabili { get; set; }
        public string FlgTipoOggetto { get; set; }
        public int? IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
