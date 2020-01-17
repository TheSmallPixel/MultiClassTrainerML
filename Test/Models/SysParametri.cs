using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysParametri
    {
        public decimal IdParametro { get; set; }
        public decimal? IdTabella { get; set; }
        public DateTime? DtData { get; set; }
        public string Stringa { get; set; }
        public decimal? IdCompagnia { get; set; }
        public decimal? Numero { get; set; }
        public string FlgTipoParametro { get; set; }
        public string FlgTipoParametro2 { get; set; }
        public string FlgTipoParametro3 { get; set; }
        public string FlgModificabileSino { get; set; }
        public decimal? Importo { get; set; }

        public virtual TabCompagnie IdCompagniaNavigation { get; set; }
    }
}
