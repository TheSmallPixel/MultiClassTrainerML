using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class FrmVariabili
    {
        public int KeyFrmVariabile { get; set; }
        public int IdFrmVariabile { get; set; }
        public string CodParametro { get; set; }
        public int? IdDescrizione { get; set; }
        public int? IdParametroPrincipale { get; set; }
        public string FlgFormatoVariabile { get; set; }
        public int? Lunghezza { get; set; }
        public int? Precisione { get; set; }
        public int? IdUtente { get; set; }
        public string FlgSceltaMultiplaSino { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdFrmGruppoVariabili { get; set; }
        public string Descrizione { get; set; }
        public string FlgObbligatorioSino { get; set; }
        public int? Ordine { get; set; }
        public int? IdFormulaVisibilita { get; set; }
    }
}
