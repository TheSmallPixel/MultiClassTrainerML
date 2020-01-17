using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabValute
    {
        public TabValute()
        {
            TabCambi = new HashSet<TabCambi>();
        }

        public decimal IdValuta { get; set; }
        public string CodValuta { get; set; }
        public decimal IdDescrizione { get; set; }
        public DateTime DtInizioValid { get; set; }
        public DateTime DtFineValid { get; set; }
        public decimal? CodValutaUic { get; set; }
        public string FlgGestitaSino { get; set; }
        public string Descrizione { get; set; }

        public virtual ICollection<TabCambi> TabCambi { get; set; }
    }
}
