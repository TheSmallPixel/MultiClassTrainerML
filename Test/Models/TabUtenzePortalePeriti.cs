using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabUtenzePortalePeriti
    {
        public int KeyUtenzaPpFiduciario { get; set; }
        public int IdUtenzaPpFiduciario { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
        public int IdFiduciario { get; set; }
        public int IdTipoPortalePeriti { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string ProxyPassword { get; set; }
        public string ProxyUsername { get; set; }
        public string ChiaveConfigPassword { get; set; }
        public string ChiaveConfigProxyPw { get; set; }
    }
}
