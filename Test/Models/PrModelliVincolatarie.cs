using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrModelliVincolatarie
    {
        public PrModelliVincolatarie()
        {
            PolVincoliTesti = new HashSet<PolVincoliTesti>();
            PrProdModVincolatarie = new HashSet<PrProdModVincolatarie>();
        }

        public decimal IdModVincolataria { get; set; }
        public decimal IdModello { get; set; }
        public DateTime DtInizioValidita { get; set; }
        public DateTime DtFineValidita { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal IdPrVincolataria { get; set; }

        public virtual PrVincolatarie IdPrVincolatariaNavigation { get; set; }
        public virtual ICollection<PolVincoliTesti> PolVincoliTesti { get; set; }
        public virtual ICollection<PrProdModVincolatarie> PrProdModVincolatarie { get; set; }
    }
}
