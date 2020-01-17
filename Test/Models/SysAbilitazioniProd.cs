using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysAbilitazioniProd
    {
        public SysAbilitazioniProd()
        {
            SysAbilitazioniMenu = new HashSet<SysAbilitazioniMenu>();
        }

        public decimal IdAbilitazioneprodotto { get; set; }
        public string NomeProdottoIsuite { get; set; }
        public decimal IdProfilo { get; set; }

        public virtual SysProfili IdProfiloNavigation { get; set; }
        public virtual ICollection<SysAbilitazioniMenu> SysAbilitazioniMenu { get; set; }
    }
}
