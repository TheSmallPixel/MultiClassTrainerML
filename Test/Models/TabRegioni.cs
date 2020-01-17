using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabRegioni
    {
        public TabRegioni()
        {
            TabProvince = new HashSet<TabProvince>();
        }

        public decimal IdRegione { get; set; }
        public decimal? IdDescrizione { get; set; }
        public string CodRegione { get; set; }
        public string Descrizione { get; set; }

        public virtual ICollection<TabProvince> TabProvince { get; set; }
    }
}
