using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysLingue
    {
        public SysLingue()
        {
            RepModelliLingue = new HashSet<RepModelliLingue>();
            SysDizionario = new HashSet<SysDizionario>();
            SysUtenti = new HashSet<SysUtenti>();
        }

        public decimal IdLingua { get; set; }
        public string CodLingua { get; set; }
        public decimal? IdDescrizione { get; set; }
        public string Descrizione { get; set; }

        public virtual ICollection<RepModelliLingue> RepModelliLingue { get; set; }
        public virtual ICollection<SysDizionario> SysDizionario { get; set; }
        public virtual ICollection<SysUtenti> SysUtenti { get; set; }
    }
}
