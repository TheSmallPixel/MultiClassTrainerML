using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabMerci
    {
        public TabMerci()
        {
            SinSinistriTrasporti = new HashSet<SinSinistriTrasporti>();
        }

        public decimal IdMerce { get; set; }
        public decimal IdCompagnia { get; set; }
        public string CodTipoMerce { get; set; }
        public decimal IdDescrizione { get; set; }
        public string Descrizione { get; set; }

        public virtual ICollection<SinSinistriTrasporti> SinSinistriTrasporti { get; set; }
    }
}
