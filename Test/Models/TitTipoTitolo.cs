using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TitTipoTitolo
    {
        public TitTipoTitolo()
        {
            TitTitoli = new HashSet<TitTitoli>();
        }

        public decimal IdTitTipoTitolo { get; set; }
        public string CodTipoTitolo { get; set; }
        public decimal? IdDescTipoTitolo { get; set; }
        public string FlgAnnullabileSino { get; set; }
        public string FlgCategoriaEmesso { get; set; }
        public string DescTipoTitolo { get; set; }

        public virtual ICollection<TitTitoli> TitTitoli { get; set; }
    }
}
