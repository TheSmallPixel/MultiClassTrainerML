using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabExtraProvvigioni
    {
        public int IdExtraprovvigione { get; set; }
        public int? IdRetevendita { get; set; }
        public string CodNodo { get; set; }
        public int? IdDescNodo { get; set; }
        public string DescNodo { get; set; }
        public string CodRaggruppamentoEc { get; set; }
        public int? IdExtraprovvigioneSup { get; set; }
        public int? IdPrProdotto { get; set; }
        public decimal PctNetto { get; set; }
        public decimal PctAccessori { get; set; }
        public decimal PctImposte { get; set; }
        public string FlgTipoCalcoloExtraProvv { get; set; }
    }
}
