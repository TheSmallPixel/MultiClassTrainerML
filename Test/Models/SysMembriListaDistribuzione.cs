using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysMembriListaDistribuzione
    {
        public decimal IdMembroListaDistribuzione { get; set; }
        public decimal IdListaDistribuzione { get; set; }
        public decimal IdUtente { get; set; }

        public virtual SysListeDistribuzione IdListaDistribuzioneNavigation { get; set; }
    }
}
