using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysFlagvalue
    {
        public decimal IdFlgvalue { get; set; }
        public decimal IdFlgcode { get; set; }
        public string CodValoreFlagSistema { get; set; }
        public decimal IdDescrizione { get; set; }
        public string Descrizione { get; set; }
        public DateTime? DtIniVal { get; set; }
        public DateTime? DtFinVal { get; set; }

        public virtual SysFlagcode IdFlgcodeNavigation { get; set; }
    }
}
