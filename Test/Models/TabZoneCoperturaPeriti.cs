using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabZoneCoperturaPeriti
    {
        public decimal IdZonacopertura { get; set; }
        public decimal? IdComune { get; set; }
        public string Cap { get; set; }
        public decimal IdFiduciario { get; set; }
        public decimal IdCompagnia { get; set; }
        public string FlgAbilitatoReSino { get; set; }
        public string FlgAbilitatoAutoSino { get; set; }

        public virtual TabFiduciari IdFiduciarioNavigation { get; set; }
    }
}
