using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabMarche
    {
        public TabMarche()
        {
            TabModelli = new HashSet<TabModelli>();
        }

        public decimal IdMarca { get; set; }
        public string CodMarca { get; set; }
        public string DescMarca { get; set; }

        public virtual ICollection<TabModelli> TabModelli { get; set; }
    }
}
