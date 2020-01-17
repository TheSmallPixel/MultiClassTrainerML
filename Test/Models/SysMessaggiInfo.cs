using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysMessaggiInfo
    {
        public int KeySysMessaggiInfo { get; set; }
        public int? IdSysMessaggiInfo { get; set; }
        public string Pagina { get; set; }
        public string Controllo { get; set; }
        public int IdDescrizione { get; set; }
        public string Descrizione { get; set; }
        public int? IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
