using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabConvenzioniAgenzie
    {
        public decimal IdConvenzioneAgenzia { get; set; }
        public decimal IdConvenzione { get; set; }
        public decimal IdRetevendita { get; set; }

        public virtual TabConvenzioni IdConvenzioneNavigation { get; set; }
    }
}
