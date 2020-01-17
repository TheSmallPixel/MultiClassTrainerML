using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolProvvigioni
    {
        public decimal KeyPolProvvigione { get; set; }
        public decimal? IdPolProvvigione { get; set; }
        public decimal? IdPolGaranzia { get; set; }
        public decimal? IdPolizza { get; set; }
        public decimal? IdAgenzia { get; set; }
        public decimal? ImpGarAcquisto { get; set; }
        public decimal? ImpGarIncasso { get; set; }
        public decimal? ImpAccAcquisto { get; set; }
        public decimal? ImpAccIncasso { get; set; }
        public decimal IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? ImpGarAcquistoOperazione { get; set; }
        public decimal? ImpGarIncassoOperazione { get; set; }
        public decimal? ImpAccAcquistoOperazione { get; set; }
        public decimal? ImpAccIncassoOperazione { get; set; }
        public decimal? PctGarAcquisto { get; set; }
        public decimal? PctGarIncasso { get; set; }
        public decimal? PctAccAcquisto { get; set; }
        public decimal? PctAccIncasso { get; set; }
        public decimal? PctGarAcquistoOperazione { get; set; }
        public decimal? PctGarIncassoOperazione { get; set; }
        public decimal? PctAccAcquistoOperazione { get; set; }
        public decimal? PctAccIncassoOperazione { get; set; }
        public string FlgDerogaPrvGarSino { get; set; }
        public string FlgDerogaPrvAccSino { get; set; }
        public string FlgDerogaPrvGarOperazSino { get; set; }
        public string FlgDerogaPrvAccOperazSino { get; set; }
        public decimal? CodDerogaPrvAccOperaz { get; set; }
        public decimal? CodDerogaPrvAcc { get; set; }
        public decimal? CodDerogaPrvGarOperaz { get; set; }
        public decimal? CodDerogaPrvGar { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
