using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolProvvigioniFirma
    {
        public decimal IdPolProvvigioneFirma { get; set; }
        public decimal? IdPolProvvigione { get; set; }
        public decimal? IdPolizza { get; set; }
        public decimal? ImpGarAcquisto { get; set; }
        public decimal? ImpGarIncasso { get; set; }
        public decimal? ImpAccAcquisto { get; set; }
        public decimal? ImpAccIncasso { get; set; }
        public decimal? PctGarAcquisto { get; set; }
        public decimal? PctGarIncasso { get; set; }
        public decimal? PctAccAcquisto { get; set; }
        public decimal? PctAccIncasso { get; set; }
        public string FlgDerogaPrvGarSino { get; set; }
        public string FlgDerogaPrvAccSino { get; set; }
        public string FlgPrimaEmissioneSino { get; set; }
        public DateTime? DtEffetto { get; set; }
        public decimal? CodDerogaPrvAcc { get; set; }
        public decimal? CodDerogaPrvGar { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
