using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabOperazioniLinee
    {
        public decimal IdTabOperazioneLinea { get; set; }
        public decimal IdTabOperazione { get; set; }
        public string FlgLineaProdotto { get; set; }

        public virtual TabOperazioni IdTabOperazioneNavigation { get; set; }
    }
}
