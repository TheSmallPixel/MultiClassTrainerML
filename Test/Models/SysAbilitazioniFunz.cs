using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysAbilitazioniFunz
    {
        public decimal IdAbilitazioneFunz { get; set; }
        public decimal IdProfilo { get; set; }
        public string CodFunzione { get; set; }
        public string ValoriParametroEccezioni { get; set; }

        public virtual SysProfili IdProfiloNavigation { get; set; }
    }
}
