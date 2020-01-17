using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabProvince
    {
        public TabProvince()
        {
            TabComuni = new HashSet<TabComuni>();
        }

        public decimal IdProvincia { get; set; }
        public string CodProvincia { get; set; }
        public decimal IdDescrizione { get; set; }
        public decimal? IdRegione { get; set; }
        public string CodUfficioIva { get; set; }
        public string Descrizione { get; set; }
        public string CodIsvap { get; set; }
        public string CodStatisticheIvass { get; set; }

        public virtual TabRegioni IdRegioneNavigation { get; set; }
        public virtual ICollection<TabComuni> TabComuni { get; set; }
    }
}
