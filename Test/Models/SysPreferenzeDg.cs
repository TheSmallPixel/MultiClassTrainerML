using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysPreferenzeDg
    {
        public decimal IdPreferenzaDg { get; set; }
        public decimal? IdUtente { get; set; }
        public string ChiaveDatagrid { get; set; }
        public decimal? NumElePagina { get; set; }
        public string Ordinamento { get; set; }
    }
}
