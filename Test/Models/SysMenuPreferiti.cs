using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysMenuPreferiti
    {
        public decimal IdMenuPreferito { get; set; }
        public decimal IdUtente { get; set; }
        public decimal IdMenuprocedura { get; set; }
        public decimal? Ordine { get; set; }

        public virtual SysMenu IdMenuproceduraNavigation { get; set; }
        public virtual SysUtenti IdUtenteNavigation { get; set; }
    }
}
