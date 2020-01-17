using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysUtentiPassword
    {
        public decimal IdUtentepassword { get; set; }
        public decimal? IdUtente { get; set; }
        public string Password { get; set; }

        public virtual SysUtenti IdUtenteNavigation { get; set; }
    }
}
