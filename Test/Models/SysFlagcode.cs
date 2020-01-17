using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysFlagcode
    {
        public SysFlagcode()
        {
            SysFlagvalue = new HashSet<SysFlagvalue>();
        }

        public decimal IdFlgcode { get; set; }
        public string CodFlagSistema { get; set; }
        public decimal IdDescrizione { get; set; }
        public string FlagReadOnly { get; set; }
        public string FlgFormatoVariabile { get; set; }
        public decimal? Lunghezza { get; set; }
        public string Descrizione { get; set; }
        public string FlgStoricoSino { get; set; }
        public string FlgMulticompSino { get; set; }

        public virtual ICollection<SysFlagvalue> SysFlagvalue { get; set; }
    }
}
