using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysFlagcodeCol
    {
        public decimal IdFlgcodeCol { get; set; }
        public decimal IdFlgcode { get; set; }
        public decimal IdDescrizione { get; set; }
        public string Descrizione { get; set; }
        public string NomeColonna { get; set; }
        public string FlgFormato { get; set; }
        public decimal? Dimensione { get; set; }
        public decimal? Precisione { get; set; }
        public decimal? Ordine { get; set; }
        public decimal? IdFlgcodeRel { get; set; }
        public string FlgObbligatorioSino { get; set; }
    }
}
