using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabCambi
    {
        public decimal IdCambio { get; set; }
        public decimal IdValuta { get; set; }
        public decimal CoeffCambio { get; set; }
        public DateTime DtInizioValidita { get; set; }
        public DateTime DtFineValidita { get; set; }

        public virtual TabValute IdValutaNavigation { get; set; }
    }
}
