using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class FrmEleValVariabili
    {
        public int KeyFrmElencoValori { get; set; }
        public int IdFrmElencoValori { get; set; }
        public int? IdFrmElencoValoriPrin { get; set; }
        public int IdFrmVariabile { get; set; }
        public string CodParametro { get; set; }
        public int? IdDescrizione { get; set; }
        public string FlgFormatoVariabile { get; set; }
        public string ValoreStringa { get; set; }
        public DateTime? ValoreData { get; set; }
        public decimal? ValoreNumerico { get; set; }
        public int? Ordine { get; set; }
        public int? IdUtente { get; set; }
        public string FlgNonInElencoSino { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string Descrizione { get; set; }
        public int? Lunghezza { get; set; }
        public int? Precisione { get; set; }
        public string FlgTestoMaiuscoloSino { get; set; }
        public string FlgObbligatorioSino { get; set; }
        public DateTime? ValoreDataDefault { get; set; }
        public string ValoreStringaDefault { get; set; }
        public int? IdCampoCollegato { get; set; }
        public decimal? ValoreNumericoDefault { get; set; }
        public int? IdFormulaVisibilita { get; set; }
        public int? IdFormulaValidazione { get; set; }
        public int? LarghezzaLabel { get; set; }
        public int? IdFormulaValorizzazione { get; set; }
        public string FlgNascostoSino { get; set; }
    }
}
