using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabComuni
    {
        public decimal IdComune { get; set; }
        public string CodComuneMinisteriale { get; set; }
        public decimal IdDescrizione { get; set; }
        public decimal IdProvincia { get; set; }
        public string Cap { get; set; }
        public string FlgSoppressoSino { get; set; }
        public string CodIsvap { get; set; }
        public decimal? IdNazione { get; set; }
        public string Descrizione { get; set; }
        public DateTime? DtInizioValidita { get; set; }
        public DateTime? DtFineValidita { get; set; }
        public string DescDenormalizzata { get; set; }

        public virtual TabProvince IdProvinciaNavigation { get; set; }
    }
}
