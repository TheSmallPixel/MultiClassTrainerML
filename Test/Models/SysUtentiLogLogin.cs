using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysUtentiLogLogin
    {
        public decimal IdUtenteLogLogin { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime DtLogin { get; set; }
        public string IpSorgente { get; set; }
        public string NomePc { get; set; }
        public string IpDestinazione { get; set; }
        public string NomeServer { get; set; }
        public string FlgAzioneLog { get; set; }
        public string FlgMotivoLoginFallito { get; set; }
    }
}
