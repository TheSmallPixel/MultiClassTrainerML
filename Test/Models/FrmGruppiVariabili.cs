using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class FrmGruppiVariabili
    {
        public int KeyFrmGruppoVariabili { get; set; }
        public int IdFrmGruppoVariabili { get; set; }
        public int IdDescrizioneGruppo { get; set; }
        public int? IdDescrizioneBottone { get; set; }
        public string FlgInPaginaSino { get; set; }
        public int? IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string CodGruppo { get; set; }
        public string DescrizioneGruppo { get; set; }
        public string DescrizioneBottone { get; set; }
        public DateTime? DtInizioValidita { get; set; }
        public DateTime? DtFineValidita { get; set; }
        public string FlgTipoEntitaVar { get; set; }
        public int? Versione { get; set; }
        public int? IdFormulaVisibilita { get; set; }
    }
}
