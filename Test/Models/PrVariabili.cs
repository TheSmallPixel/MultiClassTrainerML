using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrVariabili
    {
        public decimal KeyPrVariabile { get; set; }
        public decimal IdPrVariabile { get; set; }
        public string CodParametro { get; set; }
        public decimal? IdDescrizione { get; set; }
        public decimal? IdParametroPrincipale { get; set; }
        public string FlgFormatoVariabile { get; set; }
        public decimal? Lunghezza { get; set; }
        public decimal? Precisione { get; set; }
        public decimal? IdUtente { get; set; }
        public string FlgSceltaMultiplaSino { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdPrGruppoVariabili { get; set; }
        public string Descrizione { get; set; }
        public string FlgObbligatorioSino { get; set; }
    }
}
