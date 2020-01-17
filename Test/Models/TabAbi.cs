using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabAbi
    {
        public TabAbi()
        {
            TabCab = new HashSet<TabCab>();
        }

        public decimal IdAbi { get; set; }
        public string CodAbi { get; set; }
        public string Denominazione { get; set; }
        public DateTime? DtInizioValidita { get; set; }
        public DateTime? DtFineValidita { get; set; }

        public virtual ICollection<TabCab> TabCab { get; set; }
    }
}
