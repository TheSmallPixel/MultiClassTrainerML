using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabModelli
    {
        public TabModelli()
        {
            TabAllestimenti = new HashSet<TabAllestimenti>();
        }

        public decimal IdModello { get; set; }
        public decimal? IdMarca { get; set; }
        public string CodModello { get; set; }
        public string DescModello { get; set; }

        public virtual TabMarche IdMarcaNavigation { get; set; }
        public virtual ICollection<TabAllestimenti> TabAllestimenti { get; set; }
    }
}
