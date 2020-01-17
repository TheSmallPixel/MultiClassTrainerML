using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabAllestimenti
    {
        public decimal IdAllestimento { get; set; }
        public decimal? IdModello { get; set; }
        public string CodAllestimento { get; set; }
        public string DescAllestimento { get; set; }

        public virtual TabModelli IdModelloNavigation { get; set; }
    }
}
