using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysLogJob
    {
        public decimal IdLogJob { get; set; }
        public decimal IdDettaglioJob { get; set; }
        public string FlgTipoSegnalazione { get; set; }
        public string StringaSegnalazione { get; set; }

        public virtual SysDettagliJob IdDettaglioJobNavigation { get; set; }
    }
}
