using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysAbilitazioniMenu
    {
        public decimal IdAbilitazionemenu { get; set; }
        public decimal IdMenuprocedura { get; set; }
        public decimal IdAbilitazioneprodotto { get; set; }

        public virtual SysAbilitazioniProd IdAbilitazioneprodottoNavigation { get; set; }
        public virtual SysMenu IdMenuproceduraNavigation { get; set; }
    }
}
