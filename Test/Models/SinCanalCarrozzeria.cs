using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinCanalCarrozzeria
    {
        public int IdCanalCarrozzeria { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdCarrozzeriaConvenzionata { get; set; }
        public int? IdNetwork { get; set; }
        public int? IdRetevendita { get; set; }
        public DateTime? DtRegistrazione { get; set; }
        public DateTime? DtPagamentoIndennizzo { get; set; }
        public DateTime? DtScarico { get; set; }
        public string FlgCanalizzabileSino { get; set; }
        public string FlgCanalizzatoSino { get; set; }
        public string FlgIncentivoAgenziaSino { get; set; }
    }
}
