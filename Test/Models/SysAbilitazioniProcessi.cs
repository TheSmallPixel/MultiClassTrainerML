using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysAbilitazioniProcessi
    {
        public decimal IdAbilitazioneprocesso { get; set; }
        public decimal IdProcesso { get; set; }
        public decimal IdProfilo { get; set; }

        public virtual SysProcessi IdProcessoNavigation { get; set; }
        public virtual SysProfili IdProfiloNavigation { get; set; }
    }
}
