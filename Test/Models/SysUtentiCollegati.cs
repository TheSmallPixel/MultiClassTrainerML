using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysUtentiCollegati
    {
        public int IdUtentiCollegati { get; set; }
        public string CodRaggruppamento { get; set; }
        public int IdUtente { get; set; }
        public string FlgUltimoUtilizzatoSino { get; set; }
        public DateTime? DtUltimaLogin { get; set; }
    }
}
