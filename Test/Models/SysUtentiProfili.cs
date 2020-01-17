using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysUtentiProfili
    {
        public decimal IdUtenteprofilo { get; set; }
        public decimal IdProfilo { get; set; }
        public decimal IdUtente { get; set; }

        public virtual SysProfili IdProfiloNavigation { get; set; }
    }
}
